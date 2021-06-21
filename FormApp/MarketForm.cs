using Business.Concrete;
using Business.Constants;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class MarketForm : Form
    {
        internal ProductManager productManager;
        internal UserManager userManager;
        internal CategoryManager categoryManager;
        internal AccountantManager accountantManager;
        internal OrderProductManager orderProductManager;
        internal User user;
        User SellerUser = new User();
        Product productToBuy = new Product();
        Product product = new Product();
        OrderProduct orderProduct = new OrderProduct();
       
        int chosenProductId;
        double demandQuantity;
        double demandPrice;
        bool IsSucces;
        double commussion = 0;
        double totalAmountPayable = 0;

        public MarketForm()
        {
            InitializeComponent();
        }
     
        private void MarketForm_Load(object sender, EventArgs e)
        {
            
            GetListOfProduct();
            CheckUserType();
           
        }
     

        private void CheckUserType()
        {
            if (user.IsSeller == true)
            {
                btn_Buy.Visible = false;
                txt_DemandStock.Visible = false;
            }
            if (user.IsReceiver == true)
            {
                btn_Buy.Visible = false;
            }
        }

        private void GetListOfProduct()
        {
            ClearTheLists();

            foreach (var product in productManager.GetDetailsByCategoryId(categoryManager.GetList()))
            {
                if ((product.Approve == true) && (product.IsForSale == true) && (product.UserId != user.UserId))
                {
                    lst_UserId.Items.Add(product.UserId);
                    list_ProductId.Items.Add(product.ProductId);
                    lst_CategoryId.Items.Add(product.CategoryId);
                    lst_CategoryName.Items.Add(product.CategoryName);
                    lst_ProductName.Items.Add(product.ProductName);
                    lst_UnitPrice.Items.Add(product.UnitPrice + " TL");
                    lst_UnitsInStock.Items.Add(product.UnitsInStock + " " + product.StockType);
                }
            }

        }

        private void ClearTheLists()
        {
            lst_UserId.Items.Clear();
            list_ProductId.Items.Clear();
            lst_CategoryId.Items.Clear();
            lst_CategoryName.Items.Clear();
            lst_ProductName.Items.Clear();
            lst_UnitPrice.Items.Clear();
            lst_UnitsInStock.Items.Clear();
        }
        
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            commussion = 0;
            totalAmountPayable = 0;
            string message = "";
           
            if (txt_DemandStock.Text != "" && txt_DemandPrice.Text != "")
            {
                demandQuantity = Convert.ToDouble(txt_DemandStock.Text);
                demandPrice = Convert.ToDouble(txt_DemandPrice.Text);
               
                DefineTheVariables();// Komisyon tutar ve toplam ödenecek tutarları tanımladığımız değişken
                FindTheSellerUser(); // Satan kullanıcın verilerine erişmek için 

                //Ürünün tamamı satın alınmış ise
                if ((user.Balance >= totalAmountPayable) && (demandPrice == productToBuy.UnitPrice) && (demandQuantity == productToBuy.UnitsInStock) )
                {
                    DoPayments();

                    product.UserId = user.UserId;
                    product.Approve = false;
                    product.IsForSale = false;

                    //Alım Satım Geçmişi oluşturmak için
                    FillTheOrderProduct(orderProduct);
                    orderProductManager.Add_SuccessedBuy(orderProduct);

                    FillTheOrderProduct(orderProduct);
                    IsSucces = true;
                    MessageBox.Show(Messages.BuyedProduct + "\nÖdenen Tutar : " + totalAmountPayable);
                }
                // Ürünün tamamı satın alınmamış ise
                else if ((user.Balance >= totalAmountPayable) && (demandPrice == productToBuy.UnitPrice) && (demandQuantity < productToBuy.UnitsInStock))
                {
                    DoPayments();

                    product.UnitsInStock -= demandQuantity;
                    productToBuy.UserId = user.UserId;
                    productToBuy.UnitsInStock = demandQuantity;
                    productToBuy.Approve = false;
                    productToBuy.IsForSale = false;
                    FillTheOrderProduct(orderProduct);
                    orderProductManager.Add_SuccessedBuy(orderProduct);
                    productManager.Add(productToBuy);
                    IsSucces = true;
                    MessageBox.Show(Messages.BuyedProduct + "\nÖdenen Tutar : " + totalAmountPayable);
                }
                // İstenilen stokta ürün var ama fiyat istenilenin dışında ise 
                else if ((user.Balance >= totalAmountPayable ) && (demandPrice != productToBuy.UnitPrice) && (demandQuantity <= productToBuy.UnitsInStock))
                {
                    FillTheOrderProduct(orderProduct);
                    MessageBox.Show(orderProduct.DemandPrice.ToString());
                    message += Messages.InsufficientDemandPrice;
                    message +="\nİstenilen fiyat için" + Messages.SuccessedGetOrder;
                    orderProductManager.Add(orderProduct);
                    IsSucces = false;
                }
                // üründen istenilen stokta ve alım fiyatında yok ise
                else if ((user.Balance >= totalAmountPayable) && (demandPrice != productToBuy.UnitPrice) && (demandQuantity > productToBuy.UnitsInStock))
                {
                    FillTheOrderProduct(orderProduct);
                    message += "\nİstenilen fiyat ve yeterli ürün için " + Messages.SuccessedGetOrder;
                    orderProductManager.Add(orderProduct);
                    IsSucces = false;

                }
                // Eğer Bakiye yetersiz ise
                else if ((user.Balance < totalAmountPayable)  && (productToBuy.UnitsInStock == demandQuantity) &&(demandPrice == productToBuy.UnitPrice))
                {
                   
                    message += Messages.InsufficientBalance;
                    
                    IsSucces = false;
                    txt_DemandStock.Focus();

                }
                // Eğer Ürün stoğu yeterli miktarda yok ise
                 else if ((demandQuantity > productToBuy.UnitsInStock) && (demandPrice == productToBuy.UnitPrice) && (user.Balance >= totalAmountPayable))
                {
                    message += Messages.InsufficientStock;
                    
                    FillTheOrderProduct(orderProduct);
                    message += Messages.SuccessedGetOrder;
                    orderProductManager.Add(orderProduct);
                  
                    IsSucces = false;
                    txt_DemandStock.Focus();
                }
                // İşlemin başarılı olup olmadığını kontrol etmek için
                if (IsSucces == true)
                {
                    MessageBox.Show(Messages.SuccessedSale);
                    txt_DemandStock.Focus();
                    GetListOfProduct();
                    return;
                }
                else
                {
                    MessageBox.Show(Messages.FailedSale + message);
                    txt_DemandStock.Focus();
                    GetListOfProduct();
                    return;
                }


            }
            else
            {
                txt_DemandStock.Visible = true;
                txt_DemandStock.Focus();
                MessageBox.Show("Kaç " + product.StockType + " alacağınızı giriniz.");
            }
        }

        private void DoPayments()
        {
            user.Balance -= totalAmountPayable;
            accountantManager.PayCommissinFee(commussion);
            SellerUser.Balance += product.UnitPrice * demandQuantity;
        }

        private void FillTheOrderProduct(OrderProduct orderProduct)
        {
            orderProduct.ProductId = productToBuy.ProductId;
            orderProduct.CategoryId = productToBuy.CategoryId;
            orderProduct.UserId = SellerUser.UserId; // Satan kullanıcının id'si
            orderProduct.ProductName = productToBuy.ProductName;
            orderProduct.UnitPrice = productToBuy.UnitPrice;
            orderProduct.UnitsInStock = product.UnitsInStock;
            orderProduct.StockType = product.StockType;
            orderProduct.Approve = product.Approve;
            orderProduct.IsForSale = product.IsForSale;

            orderProduct.Time = DateTime.Now;
            orderProduct.DemandPrice = demandPrice;
            orderProduct.DemandQuantity = demandQuantity;
            orderProduct.ReceiverUserId = user.UserId;
            orderProduct.TotalPaybleAmount = totalAmountPayable;
        }

        private void DefineTheVariables()
        {
          
            commussion = ((demandPrice * demandQuantity) * 1) / 100;
            totalAmountPayable = (demandPrice * demandQuantity) + commussion;
        }

        private void FindTheSellerUser()
        {
            foreach (var user in userManager.GetList())
            {
                if (user.UserId == productToBuy.UserId)
                    SellerUser = user;
            }
        }

        private void DefineTheObjects()
        {
            foreach (var p in productManager.GetList())
            {
                if (p.ProductId == chosenProductId)
                {
                    product = p; // Tamamının alınması durumunda kullanılacak değişkenin adresini atama
                    productToBuy.UserId = p.UserId; // eğer stoğun tamamını almıyorsa kullanılacak değişken atamaları yapma
                    productToBuy.ProductId = p.ProductId;
                    productToBuy.CategoryId = p.CategoryId;
                    productToBuy.ProductName = p.ProductName;
                    productToBuy.StockType = p.StockType;
                    productToBuy.UnitPrice = p.UnitPrice;
                    productToBuy.UnitsInStock = p.UnitsInStock;
                }

            }
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            UserPanelForm userPanel = new UserPanelForm();
            userPanel.userManager = userManager;
            userPanel.productManager = productManager;
            userPanel.categoryManager = categoryManager;
            userPanel.orderProductManager = orderProductManager;
            userPanel.accountantManager = accountantManager;
            userPanel.user = user;
            
            this.Close();
            userPanel.Show();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            GetListOfProduct();
        }

        private void list_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_ProductId.SelectedIndex != -1)
            {
                if ((user.IsSeller == true) && (user.IsReceiver == false))
                    btn_Buy.Visible = false;

                btn_Buy.Visible = true;
                btn_Buy.Enabled = true;

                chosenProductId = Convert.ToInt32(list_ProductId.SelectedItem.ToString());
                
                DefineTheObjects();
                txt_DemandPrice.Text = productToBuy.UnitPrice.ToString();
                txt_DemandStock.Text = productToBuy.UnitsInStock.ToString();
                
            }
        }
    }
}

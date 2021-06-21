using Business.Concrete;
using Business.Constants;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormApp
{
    public partial class OperationProductForm : Form
    {
        public OperationProductForm()
        {
            InitializeComponent();
        }
        internal CategoryManager categoryManager;
        internal ProductManager productManager;
        internal OrderProductManager orderProductManager;
        internal UserManager userManager;
        internal AccountantManager accountantManager;
        internal int chosenProductId = -1;
        internal int userId = 0;
        int chosenCategoryId;

        User receiverUser = new User();
        User sellerUser = new User();
        Product productToBeProcessed = new Product();
        Product productToBuy = new Product();



       

        private void CheckIsOrderProductExist()
        {
            double commission = 0;
            foreach (var orderProduct in orderProductManager.GetList())
            {
                // Satın alan ve Satan kullanıcıların bilgilerine erişme
                foreach (var user in userManager.GetList())
                {
                    if (user.UserId == orderProduct.ReceiverUserId)
                    {
                        receiverUser = user;
                    }
                    if (user.UserId == userId)
                        sellerUser = user;
                }
                
                // ürünün tamamı alınmış ise
                if ((orderProduct.CategoryId == productToBeProcessed.CategoryId) && (productToBeProcessed.UnitsInStock == orderProduct.DemandQuantity) && (productToBeProcessed.UnitPrice == orderProduct.DemandPrice))
                { 
                    //Alıcıdan Parayı Tahsil etme , muhasebe ödemesi ve satıcının parasının ödenmesi
                    commission = DoPayment(orderProduct);

                    productToBeProcessed.UserId = orderProduct.ReceiverUserId;
                    productToBeProcessed.Approve = false;
                    productToBeProcessed.IsForSale = false;

                    MessageBox.Show(receiverUser.FirstName + " Bey ürünü " + orderProduct.DemandPrice * orderProduct.DemandQuantity + "Tl fiyatıyla satın aldı");

                    orderProduct.Time = DateTime.Now;
                    orderProduct.UserId = userId;// Satıcının user Id'sini kayıt 
                    orderProductManager.Add_SuccessedBuy(orderProduct);
                    orderProductManager.Delete(orderProduct);
                    break;
                }
                // ürünün tamamı alınmamamış ise
                else if ((orderProduct.CategoryId == productToBeProcessed.CategoryId) && (productToBeProcessed.UnitsInStock > orderProduct.DemandQuantity) && (productToBeProcessed.UnitPrice == orderProduct.DemandPrice))
                {
                    //Alıcıdan Parayı Tahsil etme , muhasebe ödemesi ve satıcının parasının ödenmesi
                    commission = DoPayment(orderProduct);

                    productToBeProcessed.UnitsInStock -= orderProduct.DemandQuantity;
                    productManager.Update(productToBeProcessed);

                    FillObjectOfProductOrder(orderProduct);
                    productManager.Add(productToBuy);

                    MessageBox.Show(receiverUser.FirstName + " ürünü " + orderProduct.DemandPrice * orderProduct.DemandQuantity + " fiyatıyla satın aldı");
                    
                    orderProduct.Time = DateTime.Now;
                    orderProduct.UserId = userId;
                    orderProductManager.Add_SuccessedBuy(orderProduct);
                    orderProductManager.Delete(orderProduct);
                    break;
                }

            }
        }

        private void FillObjectOfProductOrder(OrderProduct orderProduct)
        {
            productToBuy.CategoryId = orderProduct.CategoryId;
            productToBuy.UserId = receiverUser.UserId;
            productToBuy.ProductName = orderProduct.ProductName;
            productToBuy.UnitPrice = orderProduct.UnitPrice;
            productToBuy.UnitsInStock = orderProduct.DemandQuantity;
            productToBuy.StockType = orderProduct.StockType;
            productToBuy.Approve = false;
            productToBuy.IsForSale = false;
        }

        private double DoPayment(OrderProduct orderProduct)
        {
            double commission = ((orderProduct.DemandPrice * orderProduct.DemandQuantity) * 1) / 100;
            receiverUser.Balance -= (orderProduct.DemandPrice + orderProduct.DemandQuantity) + commission;
            accountantManager.PayCommissinFee(commission);
            sellerUser.Balance += orderProduct.DemandPrice * orderProduct.DemandQuantity;
            return commission;
        }

        private void CheckIsBoxEmpty(string message, bool isError)
        {
            string strProductName = txt_ProductName.Text;
            string strPrice = txt_Price.Text;
            string strStock = txt_Stock.Text;
            if (string.IsNullOrEmpty(strProductName))
            {
                message += " İsim ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strPrice))
            {
                message += " Fiyat ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strStock))
            {
                message += " Stok Adeti ";
                isError = true;
            }
            if (isError == true)
            {
                message += " boş bırakılamaz ";
                return;
            }
        }

        private void CheckIfProductAdded(Product productToAdd)
        {
            foreach (var p in productManager.GetList())
            {
                if (p == productToAdd)
                {
                    MessageBox.Show(Messages.AddedProduct);
                    this.Close();
                    break;
                }
            }
        }

        private void FillObject( Product productToAdd)
        {
            if (cmb_StockType.SelectedIndex != -1)
            {
                productToAdd.UserId = userId;
                productToAdd.CategoryId = chosenCategoryId;
                productToAdd.ProductName = txt_ProductName.Text;
                productToAdd.UnitPrice = Convert.ToDouble(txt_Price.Text);
                productToAdd.UnitsInStock = Convert.ToDouble(txt_Stock.Text);
                productToAdd.StockType = cmb_StockType.SelectedItem.ToString();
                productToAdd.Approve = false;
                productToAdd.IsForSale = true;
            }
            else
            {
                cmb_StockType.Focus();
            }
            
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            foreach (var category in categoryManager.GetList())
            {
                cmb_Categories.Items.Add(category.CategoryName);
            }
            if (chosenProductId == -1)
            {
                
            }
            else
            {
                foreach (var product in productManager.GetList())
                {
                    
                    if ( (product.ProductId == chosenProductId) && (product.UserId == userId) )
                    {
                        productToBeProcessed = product;
                        txt_ProductName.Text = product.ProductName;
                        txt_Price.Text = product.UnitPrice.ToString();
                        txt_Stock.Text = product.UnitsInStock.ToString();
                        productToBeProcessed = product;
                        txt_Stock.Focus();
                    }
                }
            }
            foreach (var p in orderProductManager.GetList())
            {
                lst_OrderProduct.Items.Add("Ürünün Talep Edildiği zamandaki fiyatı: " + p.UnitPrice + " // Talep edilen Fiyat:" + p.DemandPrice 
                    + " // Ürünün Talep Edildiği zamandaki Stoğu: " + p.UnitPrice + " // talep edilen Stok:" + p.DemandQuantity);
            }
        }

        private void cmb_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Categories.SelectedIndex != -1)
            {
                chosenCategoryId = cmb_Categories.SelectedIndex + 1;
            }
        }

        private void btn_AddProduct_Click_1(object sender, EventArgs e)
        {
            bool isError = false;
            string message = "";
            CheckIsBoxEmpty(message, isError);

            if (chosenProductId != -1)
            {
                productToBeProcessed.UnitPrice = Convert.ToDouble(txt_Price.Text);
                productToBeProcessed.UnitsInStock = Convert.ToDouble(txt_Stock.Text);
                productManager.Update(productToBeProcessed);
                MessageBox.Show(Messages.UpdatedProduct);
            }
            else
            {
                FillObject(productToBeProcessed);
                productManager.Add(productToBeProcessed);
                CheckIfProductAdded(productToBeProcessed);
            }

            CheckIsOrderProductExist();
        }
    }
}

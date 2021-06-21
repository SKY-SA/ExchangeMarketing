using AppInterface;
using Business.Concrete;
using Entities.Concrete;
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
    public partial class UserPanelForm : Form
    {
        public UserPanelForm()
        {
            InitializeComponent();
        }
        internal CategoryManager categoryManager;
        internal UserManager userManager;
        internal ProductManager productManager;
        internal AccountantManager accountantManager;
        internal OrderProductManager orderProductManager;
        internal User user;
        internal int chosenProductId;

        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLogin = new MainLoginForm();
            mainLogin.Show();
            this.Close();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            chosenProductId = -1;
            CheckUserType();
            UserInfoFiilToLabel();
            ListOfProducts();
        }

        private void CheckUserType()
        {
            // kullanıcının alıcı mı satıcı mı olduğunu belirleyip ona göre özelliklerin açık olması için yapılan kontrol
            if (user.IsReceiver == true && user.IsSeller == false)
            { 
                btn_AddProduct.Visible = false;
                btn_Update.Visible = false;
            }
            if (user.IsSeller == true && user.IsReceiver == false)
            { 
                btn_AddAmount.Visible = false;
            }
        }

        private void UserInfoFiilToLabel()
        {
            lbl_FirstName.Text = user.FirstName;
            lbl_LastName.Text = user.LastName;
            lbl_Identity.Text = user.IdentityNumber;
            lbl_UserName.Text = user.UserName;
            lbl_Password.Text = user.Password;
            lbl_Email.Text = user.Email;
            lbl_PhoneNumb.Text = "0" + user.PhoneNumber;
            lbl_Amount.Text = user.Balance.ToString() + " TL";
            lbl_Address.Text = user.Adress;
        }

        private void btn_ProductList_Click(object sender, EventArgs e)
        {
            ListOfProducts();
            lbl_Amount.Text = user.Balance.ToString();

        }

        private void ListOfProducts()
        {
            string strProductStatus = ""; // Ürün onay süreci ekrana basmak için kullanılan değişken
            ClearTheLists();
            string categoryName = "";
            foreach (var product in productManager.GetList())
            {
                if (product.Approve == true)
                    strProductStatus = "Onaylandı";
                else
                    strProductStatus = "Onay Sürecinde";
                // Eğer ürün alınmış ise 
                if (product.IsForSale == false)
                    strProductStatus = "";
                // Ayrı bir varlık sınıfı olan kategori sınıfından kategori ismini çekmek için 
                foreach (var pDto in productManager.GetDetailsByCategoryId( categoryManager.GetList() ))
                {
                    if (pDto.CategoryId == product.CategoryId)
                        categoryName = pDto.CategoryName; 
                }
                // Burada kullanıcının kendisine ait olan ürünlerin listelenmesi 
                if (product.UserId == user.UserId)
                {

                    lst_UserId.Items.Add(product.UserId);
                    lst_ProductId.Items.Add(product.ProductId);
                    lst_CategoryId.Items.Add(product.CategoryId);
                    lst_CategoryName.Items.Add(categoryName);
                    lst_ProductName.Items.Add(product.ProductName);
                    lst_UnitPrice.Items.Add(product.UnitPrice + "   TL");
                    lst_UnitsInStock.Items.Add(product.UnitsInStock + "    " + product.StockType);
                    lst_ApproveStatu.Items.Add(strProductStatus);
                }
            }
           
        }

        private void ClearTheLists()
        {
            // Listbox'ların içlerinin temizlenmesi
            lst_UserId.Items.Clear();
            lst_ProductId.Items.Clear();
            lst_CategoryId.Items.Clear();
            lst_CategoryName.Items.Clear();
            lst_ProductName.Items.Clear();
            lst_UnitPrice.Items.Clear();
            lst_UnitsInStock.Items.Clear();
            lst_ApproveStatu.Items.Clear();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            OperationProductForm form = new OperationProductForm();
            form.userId = user.UserId;
            form.productManager = productManager;
            form.categoryManager = categoryManager;
            form.orderProductManager = orderProductManager;
            form.accountantManager = accountantManager;
            form.userManager = userManager;
            form.chosenProductId = -1;
            form.Show();
        }

        private void btn_AddAmount_Click(object sender, EventArgs e)
        {
            AddUserBalanceForm addUserBalance = new AddUserBalanceForm();
            
            addUserBalance.user = user;
            addUserBalance.Show();
        }

        private void btn_Market_Click(object sender, EventArgs e)
        {
            MarketForm marketForm = new MarketForm();
            marketForm.productManager = productManager;
            marketForm.userManager = userManager;
            marketForm.categoryManager = categoryManager;
            marketForm.accountantManager = accountantManager;
            marketForm.orderProductManager = orderProductManager;
            marketForm.user = user;
            
            marketForm.Show();
            this.Hide();
        }

        private void lst_ProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ProductId.SelectedIndex != -1)
            {
                chosenProductId = Convert.ToInt32(lst_ProductId.SelectedItem.ToString());
                lst_ProductId.BackColor = Color.White;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(lst_ProductId.SelectedIndex != -1)
            {
                OperationProductForm form = new OperationProductForm();
                form.userId = user.UserId;
                form.productManager = productManager;
                form.categoryManager = categoryManager;
                form.chosenProductId = chosenProductId;
                form.orderProductManager = orderProductManager;
                form.accountantManager = accountantManager;
                form.userManager = userManager;
                form.Show();
            }
            else
            {
                MessageBox.Show("Ürün Id'si seçiniz.");
                lst_ProductId.BackColor = Color.Red;

            }
            
        }

        private void btn_purchaseHistory_Click(object sender, EventArgs e)
        {
            PurchaseHistoryForm form = new PurchaseHistoryForm();
            form.userManager = userManager;
            form.orderProductManager = orderProductManager;
            form.categoryManager = categoryManager;
            form.userId = user.UserId;
            form.Show();
        }
    }
}

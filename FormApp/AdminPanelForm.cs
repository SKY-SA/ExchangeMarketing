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
    public partial class AdminPanelForm : Form
    {
        // ilk ekranda static olarak başlatılan değişkenler ile eşitlemek için kullanılan değişkenlerin oluşturulması
        internal AdminManager adminManager;
        internal ProductManager productManager;
        internal UserManager userManager;
        internal CategoryManager categoryManager;
        internal AccountantManager accountantManager;

        public AdminPanelForm()
        {
            InitializeComponent();
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLogin = new MainLoginForm();
            mainLogin.Show();
            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ListOfProducts();
            lbl_AccountBalance.Text = accountantManager.ShowBalance().ToString();
        }

        private void ListOfProducts()
        {
            lst_UserId.Items.Clear();
            list_Id.Items.Clear();
            lst_CategoryId.Items.Clear();
            lst_CategoryName.Items.Clear();
            lst_ProductName.Items.Clear();
            lst_UnitPrice.Items.Clear();
            lst_UnitsInStock.Items.Clear();
            lst_ApproveStatu.Items.Clear();
            string productApprove = "";
            string categoryName = "";
            foreach (var product in productManager.GetList())
            {
                if (product.Approve == true)
                    productApprove = "Onaylandı";
                else
                    productApprove = "Onay Sürecinde";

                foreach (var pDto in productManager.GetDetailsByCategoryId(categoryManager.GetList()))
                {
                    if (pDto.CategoryId == product.CategoryId)
                        categoryName = pDto.CategoryName;
                }
                lst_UserId.Items.Add(product.UserId);
                list_Id.Items.Add(product.ProductId);
                lst_CategoryId.Items.Add(product.CategoryId);
                lst_CategoryName.Items.Add(categoryName);
                lst_ProductName.Items.Add(product.ProductName);
                lst_UnitPrice.Items.Add(product.UnitPrice + " TL");
                lst_UnitsInStock.Items.Add(product.UnitsInStock + " " + product.StockType);
                lst_ApproveStatu.Items.Add(productApprove);
                

            }
        }

        private void btnApproveProduct_Click(object sender, EventArgs e)
        {
            ApproveProductForm approveProductForm = new ApproveProductForm();
            approveProductForm.productManager = productManager;
            approveProductForm.userManager = userManager;
            approveProductForm.adminManager = adminManager;
            approveProductForm.categoryManager = categoryManager;
            approveProductForm.accountantManager = accountantManager;
            this.Hide();
            approveProductForm.Show();
            
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            ListOfProducts();
        }

        private void btn_ApproveBalance_Click(object sender, EventArgs e)
        {
            ApproveBalanceForm approveBalance = new ApproveBalanceForm();
            approveBalance.userManager = userManager;
            approveBalance.Show();
        }
    }
}

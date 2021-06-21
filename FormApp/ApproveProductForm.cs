using Business.Concrete;
using Business.Constants;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormApp
{
    public partial class ApproveProductForm : Form
    {
        Product productToApprove = new Product();
        internal AdminManager adminManager;
        internal ProductManager productManager;
        internal UserManager userManager;
        internal CategoryManager categoryManager;
        internal AccountantManager accountantManager;
        int productToApproveId;

        public ApproveProductForm()
        {
            InitializeComponent();
        }
       
       
        private void ApproveProduct_Load(object sender, EventArgs e)
        {
            btnApproveProduct.Enabled = false;
            ListOfNonApproveProduct();
        }

        private void ApproveTheProduct()
        {
            bool isSuccess = false;
            foreach (var product in productManager.GetList())
            {
                if (product.ProductId == productToApproveId)
                {
                    product.Approve = true;
                    if (product.Approve == true)
                    { 
                        isSuccess = true;
                        break;
                    }
                }
            }
            if (isSuccess == true)
                MessageBox.Show(Messages.approvedProduct);
           
        }

        private void ListOfNonApproveProduct()
        {
            ClearTheLists();
            string categoryName = "";
            string productApprove = "Onay Sürecinde";
            foreach (var product in productManager.GetList())
            {
                foreach (var pDto in productManager.GetDetailsByCategoryId( categoryManager.GetList() ))
                {
                    if (pDto.CategoryId == product.CategoryId)
                        categoryName = pDto.CategoryName;
                }

                if (product.Approve == false)
                {
                    lst_UserId.Items.Add(product.UserId);
                    lst_ProductId.Items.Add(product.ProductId);
                    lst_CategoryId.Items.Add(product.CategoryId);
                    lst_CategoryName.Items.Add(categoryName);
                    lst_ProductName.Items.Add(product.ProductName);
                    lst_UnitPrice.Items.Add(product.UnitPrice + " TL");
                    lst_UnitsInStock.Items.Add(product.UnitsInStock + " " + product.StockType);
                    lst_ApproveStatu.Items.Add(productApprove);
                }
            }
        }

        private void ClearTheLists()
        {
            lst_UserId.Items.Clear();
            lst_ProductId.Items.Clear();
            lst_CategoryId.Items.Clear();
            lst_CategoryName.Items.Clear();
            lst_ProductName.Items.Clear();
            lst_UnitPrice.Items.Clear();
            lst_UnitsInStock.Items.Clear();
            lst_ApproveStatu.Items.Clear();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanel = new AdminPanelForm();
            adminPanel.productManager = productManager;
            adminPanel.userManager = userManager;
            adminPanel.adminManager = adminManager;
            adminPanel.categoryManager = categoryManager;
            adminPanel.accountantManager = accountantManager;
            
            this.Close();
            adminPanel.Show();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            ListOfNonApproveProduct();
        }


        private void btnApproveProduct_Click(object sender, EventArgs e)
        {
            ApproveTheProduct();
            ListOfNonApproveProduct();
        }

        private void lst_ProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_ProductId.SelectedIndex != -1)
            {
                productToApproveId = Convert.ToInt32(lst_ProductId.SelectedItem.ToString());
                foreach (var product in productManager.GetList())
                {
                    if ((product.ProductId == productToApproveId) && (product.Approve == false))
                        btnApproveProduct.Enabled = true;
                }

            }
        }
    }
}

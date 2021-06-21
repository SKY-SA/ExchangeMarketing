using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormApp
{
    public partial class MainLoginForm : Form
    {
        internal static ProductManager productManager = new ProductManager(new InMemoryProductDal());
        internal static UserManager userManager = new UserManager(new InMemoryUserDal());
        internal static AdminManager adminManager = new AdminManager(new InMemoryAdminDal());
        internal static CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
        internal static AccountantManager accountantManager = new AccountantManager(new InMemoryAccountantDal());
        internal static OrderProductManager orderProductManager = new OrderProductManager(new InMemoryOrderProdutDal());
        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void CheckIsBoxEmpty(string errorMessage,string userName, string pass, bool isError)
        {
            if (string.IsNullOrEmpty(userName))
            {
                errorMessage += "Kullanıcı adı boş geçilemez";
                isError = true;
            }
            if (string.IsNullOrEmpty(pass))
            {
                errorMessage += " Kullanıcı şifresi boş geçilemez";
                isError = true;
            }
            if (isError)
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            // kullanıcı adı veya şifre bölümünün dolu mu boş mu olduğunu kontrol etmek için oluşturulan değişkenler 
            string userName = txt_Identity.Text;
            string pass = txt_Password.Text;
            string errorMessage = "";
            var isError = false;

            CheckIsBoxEmpty(errorMessage, userName, pass, isError);
            // Veritabanında olan (Bellekte çalışılmıştır.) veri bilgilerini listeye çekme işlemi yapılıyor
            List<User> users = userManager.GetList();
            List<Admin> admins = adminManager.GetList();
            CheckIsLogin(users, admins);

        }

        private void CheckIsLogin(List<User> users, List<Admin> admins)
        {
            foreach (var user in users)
            {

                if ((txt_Identity.Text == user.UserName.Trim()) && (txt_Password.Text == user.Password.Trim()))
                {
                    UserPanelForm userPanel = new UserPanelForm();
                    userPanel.userManager = userManager;
                    userPanel.productManager = productManager;
                    userPanel.categoryManager = categoryManager;
                    userPanel.accountantManager = accountantManager;
                    userPanel.orderProductManager = orderProductManager;
                    userPanel.user = user;
                    userPanel.Show();
                    this.Hide();
                    break;

                }
                continue;
            }

            foreach (var admin in admins)
            {
                if ((txt_Identity.Text == admin.IdentityNumber.Trim()) && (txt_Password.Text == admin.Password.Trim()))
                {
                    AdminPanelForm adminPanel = new AdminPanelForm();
                    adminPanel.adminManager = adminManager;
                    adminPanel.productManager = productManager;
                    adminPanel.userManager = userManager;
                    adminPanel.categoryManager = categoryManager;
                    adminPanel.accountantManager = accountantManager;
                    adminPanel.Show();
                    this.Hide();
                    break;
                }
                continue;
            }
        }

        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterUserForm registerUserForm = new RegisterUserForm();
            registerUserForm.userManager = userManager;
            registerUserForm.Show();
            this.Hide();
        }
    }
}

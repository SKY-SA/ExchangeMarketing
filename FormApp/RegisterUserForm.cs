using Business.Concrete;
using Business.Constants;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormApp
{
    public partial class RegisterUserForm : Form
    {
        int choosenUserType;
        public RegisterUserForm()
        {
            InitializeComponent();
        }
        internal UserManager userManager;

        private void btn_Register_Click(object sender, EventArgs e)
        {
            bool isError = false;
            //string message = "";
            isError = CheckIsBoxEmpty();
            if (isError == false)
            {
                User userToRegister = RegisterUser();
                CheckIsUserRegister(userToRegister);
            }
            else
                MessageBox.Show(Messages.FailedRegisteredUser1+"\nBilgiler boş bırakılamaz");
        }
        private bool CheckIsBoxEmpty()
        {
            bool isError = false;
            string strFirstName = txt_FirstName.Text;
            string strLastName = txt_LastName.Text;
            string strIdentity = txt_Identity.Text;
            string strUserName = txt_UserName.Text;
            string strPass = txt_Password.Text;
            string strEmail = txt_Mail.Text;
            string strPhoneNumb = mskTxt_Phone.Text;
            string strAdress = txt_Adress.Text;


            if (string.IsNullOrEmpty(strFirstName))
            {
                //message += " Ad ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strLastName))
            {
                //message += " Soyad  ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strIdentity))
            {
                //message += " TC ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strUserName))
            {
                //message += " Kullanıcı Adı ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strPass))
            {
               // message += " Şifre ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strEmail))
            {
                //message += " Email ";
                return isError = true;
            }
            if (string.IsNullOrEmpty(strPhoneNumb))
            {
                //message += " Telefon Numarası ";
                isError = true;
            }
            if (string.IsNullOrEmpty(strAdress))
            {
                //message = " Adres ";
                isError = true;
            }
            return isError;
        }
        private void CheckIsUserRegister(User userToRegister)
        {
            bool IsSuccess = false;
            foreach (var user in userManager.GetList())
            {
                if (user == userToRegister)
                {
                    //MessageBox.Show(Messages.RegisteredUser);
                    //CleanTheTextBoxes();
                    IsSuccess = true;
                    break;
                }
                IsSuccess = false;
            }

            if(IsSuccess)
                MessageBox.Show(Messages.SuccessRegisteredUser);
            else
                MessageBox.Show(Messages.FailedRegisteredUser);
        }

        private User RegisterUser()
        {
            User userToRegister = new User();
            userToRegister.FirstName = txt_FirstName.Text;
            userToRegister.LastName = txt_LastName.Text;
            userToRegister.IdentityNumber = txt_Identity.Text;
            userToRegister.UserName = txt_UserName.Text;
            userToRegister.Password = txt_Password.Text;
            userToRegister.Email = txt_Mail.Text;
            userToRegister.PhoneNumber = mskTxt_Phone.Text;
            userToRegister.Adress = txt_Adress.Text;
            userToRegister.Balance = 0; // Kayıt sırasında bakiye ekleme işlemi olmadığı için 
            userToRegister.BalanceApprove = true; // user kayıt olurken bakiye ekleme yapılmadığı için true değer atıyoruz. bakiye ekleme yapılırken false atanıyor.
            CheckUserType(userToRegister);
            userManager.Add(userToRegister);
            return userToRegister;
        }

        private void CheckUserType(User userToRegister)
        {
            if (cmb_UserType.SelectedIndex != -1)
            {
                if (choosenUserType == 0)
                {
                    userToRegister.IsReceiver = true;
                    userToRegister.IsSeller = false;
                }

                if (choosenUserType == 1)
                {
                    userToRegister.IsReceiver = false;
                    userToRegister.IsSeller = true;
                }
                
                if(choosenUserType == 2)
                {
                    userToRegister.IsReceiver = false;
                    userToRegister.IsSeller = false;
                }
                
               

            }
        }

        private void CleanTheTextBoxes()
        {
            txt_Identity.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_UserName.Text = "";
            txt_Password.Text = "";
            txt_Adress.Text = "";
            txt_Mail.Text = "";
            mskTxt_Phone.Text = "";
            cmb_UserType.Text = "";
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLogin = new MainLoginForm();
            mainLogin.Show();
            this.Close();
        }

        private void cmb_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_UserType.SelectedIndex != -1)
            {
                choosenUserType = cmb_UserType.SelectedIndex;
            }
        }
    }
}


namespace FormApp
{
    partial class RegisterUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUserForm));
            this.mskTxt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Identity = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cmb_UserType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mskTxt_Phone
            // 
            this.mskTxt_Phone.Location = new System.Drawing.Point(134, 244);
            this.mskTxt_Phone.Mask = "(999) 000-0000";
            this.mskTxt_Phone.Name = "mskTxt_Phone";
            this.mskTxt_Phone.Size = new System.Drawing.Size(219, 23);
            this.mskTxt_Phone.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(23, 244);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(52, 15);
            this.lblPhoneNumber.TabIndex = 34;
            this.lblPhoneNumber.Text = "Telefon :";
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Back.Location = new System.Drawing.Point(12, 342);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(81, 92);
            this.btn_Back.TabIndex = 9;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Register.BackgroundImage")));
            this.btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Register.Location = new System.Drawing.Point(134, 342);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(219, 92);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "Kayıt Ol";
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(134, 279);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(219, 23);
            this.txt_Adress.TabIndex = 7;
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Location = new System.Drawing.Point(23, 282);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(43, 15);
            this.lblAddres.TabIndex = 33;
            this.lblAddres.Text = "Adres :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(23, 209);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 15);
            this.lblMail.TabIndex = 32;
            this.lblMail.Text = "E-Mail :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 174);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 15);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Şifre :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(23, 139);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 15);
            this.lblUserName.TabIndex = 29;
            this.lblUserName.Text = "Kullanıcı Adı :";
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(23, 104);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(25, 15);
            this.lblIdentity.TabIndex = 28;
            this.lblIdentity.Text = "Tc :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(45, 15);
            this.lblLastName.TabIndex = 26;
            this.lblLastName.Text = "Soyad :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(28, 15);
            this.lblFirstName.TabIndex = 24;
            this.lblFirstName.Text = "Ad :";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(134, 206);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(219, 23);
            this.txt_Mail.TabIndex = 5;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(134, 171);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(219, 23);
            this.txt_Password.TabIndex = 4;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(134, 136);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(219, 23);
            this.txt_UserName.TabIndex = 3;
            // 
            // txt_Identity
            // 
            this.txt_Identity.Location = new System.Drawing.Point(134, 101);
            this.txt_Identity.Name = "txt_Identity";
            this.txt_Identity.Size = new System.Drawing.Size(219, 23);
            this.txt_Identity.TabIndex = 2;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(134, 66);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(219, 23);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(134, 31);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(219, 23);
            this.txt_FirstName.TabIndex = 0;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(12, 316);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(81, 15);
            this.lblUserType.TabIndex = 35;
            this.lblUserType.Text = "Kullanıcı Tipi :";
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Items.AddRange(new object[] {
            "Alıcı",
            "Satıcı",
            "Alıcı Ve Satıcı"});
            this.cmb_UserType.Location = new System.Drawing.Point(134, 313);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(219, 23);
            this.cmb_UserType.TabIndex = 36;
            this.cmb_UserType.SelectedIndexChanged += new System.EventHandler(this.cmb_UserType_SelectedIndexChanged);
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 442);
            this.Controls.Add(this.cmb_UserType);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.mskTxt_Phone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Identity);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Name = "RegisterUserForm";
            this.Text = "Kullanıcı Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTxt_Phone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Identity;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmb_UserType;
    }
}
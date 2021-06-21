
namespace FormApp
{
    partial class MainLoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLoginForm));
            this.link_Register = new System.Windows.Forms.LinkLabel();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Identity = new System.Windows.Forms.TextBox();
            this.pcBox_Marketing1 = new System.Windows.Forms.PictureBox();
            this.pcBox_Marketing2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox_Marketing1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox_Marketing2)).BeginInit();
            this.SuspendLayout();
            // 
            // link_Register
            // 
            this.link_Register.AutoSize = true;
            this.link_Register.Location = new System.Drawing.Point(358, 302);
            this.link_Register.Name = "link_Register";
            this.link_Register.Size = new System.Drawing.Size(48, 15);
            this.link_Register.TabIndex = 18;
            this.link_Register.TabStop = true;
            this.link_Register.Text = "Kayıt Ol";
            this.link_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Register_LinkClicked);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(260, 279);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(92, 15);
            this.lblUserPassword.TabIndex = 17;
            this.lblUserPassword.Text = "Kullanıcı Şifresi :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(260, 248);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 15);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "Kullanıcı Adı :";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_SignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SignIn.BackgroundImage")));
            this.btn_SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SignIn.Location = new System.Drawing.Point(493, 305);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(71, 58);
            this.btn_SignIn.TabIndex = 12;
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(358, 276);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(206, 23);
            this.txt_Password.TabIndex = 11;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Identity
            // 
            this.txt_Identity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_Identity.Location = new System.Drawing.Point(357, 240);
            this.txt_Identity.Name = "txt_Identity";
            this.txt_Identity.Size = new System.Drawing.Size(206, 29);
            this.txt_Identity.TabIndex = 10;
            // 
            // pcBox_Marketing1
            // 
            this.pcBox_Marketing1.Image = ((System.Drawing.Image)(resources.GetObject("pcBox_Marketing1.Image")));
            this.pcBox_Marketing1.Location = new System.Drawing.Point(12, 12);
            this.pcBox_Marketing1.Name = "pcBox_Marketing1";
            this.pcBox_Marketing1.Size = new System.Drawing.Size(598, 207);
            this.pcBox_Marketing1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox_Marketing1.TabIndex = 20;
            this.pcBox_Marketing1.TabStop = false;
            // 
            // pcBox_Marketing2
            // 
            this.pcBox_Marketing2.Image = ((System.Drawing.Image)(resources.GetObject("pcBox_Marketing2.Image")));
            this.pcBox_Marketing2.Location = new System.Drawing.Point(12, 225);
            this.pcBox_Marketing2.Name = "pcBox_Marketing2";
            this.pcBox_Marketing2.Size = new System.Drawing.Size(194, 128);
            this.pcBox_Marketing2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBox_Marketing2.TabIndex = 21;
            this.pcBox_Marketing2.TabStop = false;
            // 
            // MainLoginForm
            // 
            this.AcceptButton = this.btn_SignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 365);
            this.Controls.Add(this.pcBox_Marketing2);
            this.Controls.Add(this.pcBox_Marketing1);
            this.Controls.Add(this.link_Register);
            this.Controls.Add(this.lblUserPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Identity);
            this.MaximizeBox = false;
            this.Name = "MainLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pcBox_Marketing1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBox_Marketing2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel link_Register;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Identity;
        private System.Windows.Forms.PictureBox pcBox_Marketing1;
        private System.Windows.Forms.PictureBox pcBox_Marketing2;
    }
}


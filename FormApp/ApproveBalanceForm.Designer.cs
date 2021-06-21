
namespace FormApp
{
    partial class ApproveBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveBalanceForm));
            this.gBox_UserInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_MoneyType = new System.Windows.Forms.ListBox();
            this.lbl_BalanceToApprove = new System.Windows.Forms.Label();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.lstBalance = new System.Windows.Forms.ListBox();
            this.lstId = new System.Windows.Forms.ListBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.lbl_SellUsd = new System.Windows.Forms.Label();
            this.lblUsd = new System.Windows.Forms.Label();
            this.lbl_SellEuro = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txt_ExchangeAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.gBox_UserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_UserInfo
            // 
            this.gBox_UserInfo.Controls.Add(this.label1);
            this.gBox_UserInfo.Controls.Add(this.lst_MoneyType);
            this.gBox_UserInfo.Controls.Add(this.lbl_BalanceToApprove);
            this.gBox_UserInfo.Controls.Add(this.lbl_UserId);
            this.gBox_UserInfo.Controls.Add(this.lstBalance);
            this.gBox_UserInfo.Controls.Add(this.lstId);
            this.gBox_UserInfo.Location = new System.Drawing.Point(3, 9);
            this.gBox_UserInfo.Name = "gBox_UserInfo";
            this.gBox_UserInfo.Size = new System.Drawing.Size(227, 330);
            this.gBox_UserInfo.TabIndex = 0;
            this.gBox_UserInfo.TabStop = false;
            this.gBox_UserInfo.Text = "Kullanıcı Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Onaylanacak \r\nPara Birimi";
            // 
            // lst_MoneyType
            // 
            this.lst_MoneyType.FormattingEnabled = true;
            this.lst_MoneyType.ItemHeight = 15;
            this.lst_MoneyType.Location = new System.Drawing.Point(134, 47);
            this.lst_MoneyType.Name = "lst_MoneyType";
            this.lst_MoneyType.Size = new System.Drawing.Size(89, 274);
            this.lst_MoneyType.TabIndex = 4;
            // 
            // lbl_BalanceToApprove
            // 
            this.lbl_BalanceToApprove.AutoSize = true;
            this.lbl_BalanceToApprove.Location = new System.Drawing.Point(59, 15);
            this.lbl_BalanceToApprove.Name = "lbl_BalanceToApprove";
            this.lbl_BalanceToApprove.Size = new System.Drawing.Size(75, 30);
            this.lbl_BalanceToApprove.TabIndex = 3;
            this.lbl_BalanceToApprove.Text = "Onaylanacak\r\n Bakiye";
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(6, 15);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(52, 30);
            this.lbl_UserId.TabIndex = 2;
            this.lbl_UserId.Text = "Kullanıcı\r\nId";
            // 
            // lstBalance
            // 
            this.lstBalance.FormattingEnabled = true;
            this.lstBalance.ItemHeight = 15;
            this.lstBalance.Location = new System.Drawing.Point(51, 48);
            this.lstBalance.Name = "lstBalance";
            this.lstBalance.Size = new System.Drawing.Size(83, 274);
            this.lstBalance.TabIndex = 1;
            // 
            // lstId
            // 
            this.lstId.FormattingEnabled = true;
            this.lstId.ItemHeight = 15;
            this.lstId.Location = new System.Drawing.Point(6, 48);
            this.lstId.Name = "lstId";
            this.lstId.Size = new System.Drawing.Size(45, 274);
            this.lstId.TabIndex = 0;
            this.lstId.SelectedIndexChanged += new System.EventHandler(this.lstId_SelectedIndexChanged);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Accept.BackgroundImage")));
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Accept.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Accept.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Accept.Location = new System.Drawing.Point(236, 195);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(124, 144);
            this.btn_Accept.TabIndex = 1;
            this.btn_Accept.Text = "Bakiye \r\nOnayla";
            this.btn_Accept.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Location = new System.Drawing.Point(236, 9);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(33, 15);
            this.lblDateNow.TabIndex = 2;
            this.lblDateNow.Text = "Tarih";
            // 
            // lbl_SellUsd
            // 
            this.lbl_SellUsd.AutoSize = true;
            this.lbl_SellUsd.Location = new System.Drawing.Point(297, 47);
            this.lbl_SellUsd.Name = "lbl_SellUsd";
            this.lbl_SellUsd.Size = new System.Drawing.Size(38, 15);
            this.lbl_SellUsd.TabIndex = 3;
            this.lbl_SellUsd.Text = "label1";
            // 
            // lblUsd
            // 
            this.lblUsd.AutoSize = true;
            this.lblUsd.Location = new System.Drawing.Point(229, 47);
            this.lblUsd.Name = "lblUsd";
            this.lblUsd.Size = new System.Drawing.Size(69, 15);
            this.lblUsd.TabIndex = 4;
            this.lblUsd.Text = "Dolar Kuru: ";
            // 
            // lbl_SellEuro
            // 
            this.lbl_SellEuro.AutoSize = true;
            this.lbl_SellEuro.Location = new System.Drawing.Point(297, 71);
            this.lbl_SellEuro.Name = "lbl_SellEuro";
            this.lbl_SellEuro.Size = new System.Drawing.Size(38, 15);
            this.lbl_SellEuro.TabIndex = 5;
            this.lbl_SellEuro.Text = "label1";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(229, 71);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(62, 15);
            this.lblEuro.TabIndex = 6;
            this.lblEuro.Text = "Euro Kuru:";
            // 
            // txt_ExchangeAmount
            // 
            this.txt_ExchangeAmount.Enabled = false;
            this.txt_ExchangeAmount.Location = new System.Drawing.Point(236, 166);
            this.txt_ExchangeAmount.Name = "txt_ExchangeAmount";
            this.txt_ExchangeAmount.Size = new System.Drawing.Size(124, 23);
            this.txt_ExchangeAmount.TabIndex = 7;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(254, 148);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(81, 15);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Toplam Tutar ";
            // 
            // ApproveBalanceForm
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 351);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txt_ExchangeAmount);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lbl_SellEuro);
            this.Controls.Add(this.lblUsd);
            this.Controls.Add(this.lbl_SellUsd);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.gBox_UserInfo);
            this.MaximizeBox = false;
            this.Name = "ApproveBalanceForm";
            this.Text = "Bakiye Onaylama ";
            this.Load += new System.EventHandler(this.ApproveBalance_Load);
            this.gBox_UserInfo.ResumeLayout(false);
            this.gBox_UserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_UserInfo;
        private System.Windows.Forms.ListBox lstBalance;
        private System.Windows.Forms.ListBox lstId;
        private System.Windows.Forms.Label lbl_BalanceToApprove;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Label lbl_SellUsd;
        private System.Windows.Forms.Label lblUsd;
        private System.Windows.Forms.Label lbl_SellEuro;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_MoneyType;
        private System.Windows.Forms.TextBox txt_ExchangeAmount;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}
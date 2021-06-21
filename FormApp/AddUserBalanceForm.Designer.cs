
namespace FormApp
{
    partial class AddUserBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserBalanceForm));
            this.lblPriceToAdded = new System.Windows.Forms.Label();
            this.txt_PriceToAdd = new System.Windows.Forms.TextBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.lblMoneyType = new System.Windows.Forms.Label();
            this.cmb_MoneyType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPriceToAdded
            // 
            this.lblPriceToAdded.AutoSize = true;
            this.lblPriceToAdded.Location = new System.Drawing.Point(2, 75);
            this.lblPriceToAdded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceToAdded.Name = "lblPriceToAdded";
            this.lblPriceToAdded.Size = new System.Drawing.Size(131, 42);
            this.lblPriceToAdded.TabIndex = 0;
            this.lblPriceToAdded.Text = "Eklenecek Bakiye\r\nTutarını Giriniz :";
            // 
            // txt_PriceToAdd
            // 
            this.txt_PriceToAdd.Location = new System.Drawing.Point(140, 75);
            this.txt_PriceToAdd.Name = "txt_PriceToAdd";
            this.txt_PriceToAdd.Size = new System.Drawing.Size(168, 29);
            this.txt_PriceToAdd.TabIndex = 1;
            this.txt_PriceToAdd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Accept.BackgroundImage")));
            this.btn_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Accept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Accept.Location = new System.Drawing.Point(181, 110);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(127, 63);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // lblMoneyType
            // 
            this.lblMoneyType.AutoSize = true;
            this.lblMoneyType.Location = new System.Drawing.Point(2, 27);
            this.lblMoneyType.Name = "lblMoneyType";
            this.lblMoneyType.Size = new System.Drawing.Size(84, 42);
            this.lblMoneyType.TabIndex = 3;
            this.lblMoneyType.Text = "Eklenecek \r\nPara Tipi :";
            // 
            // cmb_MoneyType
            // 
            this.cmb_MoneyType.FormattingEnabled = true;
            this.cmb_MoneyType.Items.AddRange(new object[] {
            "Türk Lirası",
            "Dolar",
            "Euro"});
            this.cmb_MoneyType.Location = new System.Drawing.Point(140, 40);
            this.cmb_MoneyType.Name = "cmb_MoneyType";
            this.cmb_MoneyType.Size = new System.Drawing.Size(169, 29);
            this.cmb_MoneyType.TabIndex = 4;
            this.cmb_MoneyType.SelectedIndexChanged += new System.EventHandler(this.cmb_MoneyType_SelectedIndexChanged);
            // 
            // AddUserBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 184);
            this.Controls.Add(this.cmb_MoneyType);
            this.Controls.Add(this.lblMoneyType);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.txt_PriceToAdd);
            this.Controls.Add(this.lblPriceToAdded);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "AddUserBalanceForm";
            this.Text = "Bakiye Ekle";
            this.Load += new System.EventHandler(this.AddUserBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPriceToAdded;
        private System.Windows.Forms.TextBox txt_PriceToAdd;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label lblMoneyType;
        private System.Windows.Forms.ComboBox cmb_MoneyType;
    }
}
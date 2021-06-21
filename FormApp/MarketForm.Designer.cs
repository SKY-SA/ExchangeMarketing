
namespace FormApp
{
    partial class MarketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketForm));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.txt_DemandStock = new System.Windows.Forms.TextBox();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.gBox_ProductsToBuy = new System.Windows.Forms.GroupBox();
            this.lblStockStatu = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lbl_CategoryId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lst_UserId = new System.Windows.Forms.ListBox();
            this.lst_UnitsInStock = new System.Windows.Forms.ListBox();
            this.lst_UnitPrice = new System.Windows.Forms.ListBox();
            this.lst_ProductName = new System.Windows.Forms.ListBox();
            this.lst_CategoryName = new System.Windows.Forms.ListBox();
            this.lst_CategoryId = new System.Windows.Forms.ListBox();
            this.list_ProductId = new System.Windows.Forms.ListBox();
            this.txt_DemandPrice = new System.Windows.Forms.TextBox();
            this.lblDemandPrice = new System.Windows.Forms.Label();
            this.lblDemandStock = new System.Windows.Forms.Label();
            this.gBox_ProductsToBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(7, 487);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(81, 71);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_list.BackgroundImage")));
            this.btn_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_list.Location = new System.Drawing.Point(91, 487);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(99, 71);
            this.btn_list.TabIndex = 3;
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // txt_DemandStock
            // 
            this.txt_DemandStock.Location = new System.Drawing.Point(627, 514);
            this.txt_DemandStock.Name = "txt_DemandStock";
            this.txt_DemandStock.Size = new System.Drawing.Size(71, 23);
            this.txt_DemandStock.TabIndex = 2;
            // 
            // btn_Buy
            // 
            this.btn_Buy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Buy.BackgroundImage")));
            this.btn_Buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buy.Location = new System.Drawing.Point(704, 484);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(114, 74);
            this.btn_Buy.TabIndex = 0;
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // gBox_ProductsToBuy
            // 
            this.gBox_ProductsToBuy.Controls.Add(this.lblStockStatu);
            this.gBox_ProductsToBuy.Controls.Add(this.lblProductPrice);
            this.gBox_ProductsToBuy.Controls.Add(this.lblProductName);
            this.gBox_ProductsToBuy.Controls.Add(this.lblCategoryName);
            this.gBox_ProductsToBuy.Controls.Add(this.lbl_CategoryId);
            this.gBox_ProductsToBuy.Controls.Add(this.lblProductId);
            this.gBox_ProductsToBuy.Controls.Add(this.lblUserId);
            this.gBox_ProductsToBuy.Controls.Add(this.lst_UserId);
            this.gBox_ProductsToBuy.Controls.Add(this.lst_UnitsInStock);
            this.gBox_ProductsToBuy.Controls.Add(this.lst_UnitPrice);
            this.gBox_ProductsToBuy.Controls.Add(this.lst_ProductName);
            this.gBox_ProductsToBuy.Controls.Add(this.lst_CategoryName);
            this.gBox_ProductsToBuy.Controls.Add(this.lst_CategoryId);
            this.gBox_ProductsToBuy.Controls.Add(this.list_ProductId);
            this.gBox_ProductsToBuy.Location = new System.Drawing.Point(1, 8);
            this.gBox_ProductsToBuy.Name = "gBox_ProductsToBuy";
            this.gBox_ProductsToBuy.Size = new System.Drawing.Size(817, 473);
            this.gBox_ProductsToBuy.TabIndex = 6;
            this.gBox_ProductsToBuy.TabStop = false;
            this.gBox_ProductsToBuy.Text = "Ürünler";
            // 
            // lblStockStatu
            // 
            this.lblStockStatu.AutoSize = true;
            this.lblStockStatu.Location = new System.Drawing.Point(673, 23);
            this.lblStockStatu.Name = "lblStockStatu";
            this.lblStockStatu.Size = new System.Drawing.Size(77, 15);
            this.lblStockStatu.TabIndex = 17;
            this.lblStockStatu.Text = "Stok Durumu";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(541, 23);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(64, 15);
            this.lblProductPrice.TabIndex = 16;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(348, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 15);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(133, 23);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(76, 15);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Kategori İsmi";
            // 
            // lbl_CategoryId
            // 
            this.lbl_CategoryId.AutoSize = true;
            this.lbl_CategoryId.Location = new System.Drawing.Point(90, 23);
            this.lbl_CategoryId.Name = "lbl_CategoryId";
            this.lbl_CategoryId.Size = new System.Drawing.Size(37, 15);
            this.lbl_CategoryId.TabIndex = 13;
            this.lbl_CategoryId.Text = "Kat Id";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(46, 23);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(46, 15);
            this.lblProductId.TabIndex = 12;
            this.lblProductId.Text = "Ürün Id";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(6, 23);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(40, 15);
            this.lblUserId.TabIndex = 11;
            this.lblUserId.Text = "Kul. Id";
            // 
            // lst_UserId
            // 
            this.lst_UserId.FormattingEnabled = true;
            this.lst_UserId.ItemHeight = 15;
            this.lst_UserId.Location = new System.Drawing.Point(6, 41);
            this.lst_UserId.Name = "lst_UserId";
            this.lst_UserId.Size = new System.Drawing.Size(40, 424);
            this.lst_UserId.TabIndex = 10;
            // 
            // lst_UnitsInStock
            // 
            this.lst_UnitsInStock.FormattingEnabled = true;
            this.lst_UnitsInStock.ItemHeight = 15;
            this.lst_UnitsInStock.Location = new System.Drawing.Point(673, 41);
            this.lst_UnitsInStock.Name = "lst_UnitsInStock";
            this.lst_UnitsInStock.Size = new System.Drawing.Size(131, 424);
            this.lst_UnitsInStock.TabIndex = 8;
            // 
            // lst_UnitPrice
            // 
            this.lst_UnitPrice.FormattingEnabled = true;
            this.lst_UnitPrice.ItemHeight = 15;
            this.lst_UnitPrice.Location = new System.Drawing.Point(541, 41);
            this.lst_UnitPrice.Name = "lst_UnitPrice";
            this.lst_UnitPrice.Size = new System.Drawing.Size(132, 424);
            this.lst_UnitPrice.TabIndex = 7;
            // 
            // lst_ProductName
            // 
            this.lst_ProductName.FormattingEnabled = true;
            this.lst_ProductName.ItemHeight = 15;
            this.lst_ProductName.Location = new System.Drawing.Point(348, 41);
            this.lst_ProductName.Name = "lst_ProductName";
            this.lst_ProductName.Size = new System.Drawing.Size(193, 424);
            this.lst_ProductName.TabIndex = 6;
            // 
            // lst_CategoryName
            // 
            this.lst_CategoryName.FormattingEnabled = true;
            this.lst_CategoryName.ItemHeight = 15;
            this.lst_CategoryName.Location = new System.Drawing.Point(135, 41);
            this.lst_CategoryName.Name = "lst_CategoryName";
            this.lst_CategoryName.Size = new System.Drawing.Size(213, 424);
            this.lst_CategoryName.TabIndex = 5;
            // 
            // lst_CategoryId
            // 
            this.lst_CategoryId.FormattingEnabled = true;
            this.lst_CategoryId.ItemHeight = 15;
            this.lst_CategoryId.Location = new System.Drawing.Point(90, 41);
            this.lst_CategoryId.Name = "lst_CategoryId";
            this.lst_CategoryId.Size = new System.Drawing.Size(45, 424);
            this.lst_CategoryId.TabIndex = 4;
            // 
            // list_ProductId
            // 
            this.list_ProductId.FormattingEnabled = true;
            this.list_ProductId.ItemHeight = 15;
            this.list_ProductId.Location = new System.Drawing.Point(46, 41);
            this.list_ProductId.Name = "list_ProductId";
            this.list_ProductId.Size = new System.Drawing.Size(44, 424);
            this.list_ProductId.TabIndex = 3;
            this.list_ProductId.SelectedIndexChanged += new System.EventHandler(this.list_Id_SelectedIndexChanged);
            // 
            // txt_DemandPrice
            // 
            this.txt_DemandPrice.Location = new System.Drawing.Point(533, 514);
            this.txt_DemandPrice.Name = "txt_DemandPrice";
            this.txt_DemandPrice.Size = new System.Drawing.Size(92, 23);
            this.txt_DemandPrice.TabIndex = 7;
            // 
            // lblDemandPrice
            // 
            this.lblDemandPrice.AutoSize = true;
            this.lblDemandPrice.Location = new System.Drawing.Point(533, 496);
            this.lblDemandPrice.Name = "lblDemandPrice";
            this.lblDemandPrice.Size = new System.Drawing.Size(38, 15);
            this.lblDemandPrice.TabIndex = 8;
            this.lblDemandPrice.Text = "Fiyat :";
            // 
            // lblDemandStock
            // 
            this.lblDemandStock.AutoSize = true;
            this.lblDemandStock.Location = new System.Drawing.Point(627, 496);
            this.lblDemandStock.Name = "lblDemandStock";
            this.lblDemandStock.Size = new System.Drawing.Size(38, 15);
            this.lblDemandStock.TabIndex = 9;
            this.lblDemandStock.Text = "Adet :";
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 565);
            this.Controls.Add(this.lblDemandStock);
            this.Controls.Add(this.lblDemandPrice);
            this.Controls.Add(this.txt_DemandPrice);
            this.Controls.Add(this.txt_DemandStock);
            this.Controls.Add(this.gBox_ProductsToBuy);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_Back);
            this.Name = "MarketForm";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.MarketForm_Load);
            this.gBox_ProductsToBuy.ResumeLayout(false);
            this.gBox_ProductsToBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.TextBox txt_DemandStock;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.GroupBox gBox_ProductsToBuy;
        private System.Windows.Forms.Label lblStockStatu;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lbl_CategoryId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ListBox lst_UserId;
        private System.Windows.Forms.ListBox lst_UnitsInStock;
        private System.Windows.Forms.ListBox lst_UnitPrice;
        private System.Windows.Forms.ListBox lst_ProductName;
        private System.Windows.Forms.ListBox lst_CategoryName;
        private System.Windows.Forms.ListBox lst_CategoryId;
        private System.Windows.Forms.ListBox list_ProductId;
        private System.Windows.Forms.TextBox txt_DemandPrice;
        private System.Windows.Forms.Label lblDemandPrice;
        private System.Windows.Forms.Label lblDemandStock;
    }
}
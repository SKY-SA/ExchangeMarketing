
namespace FormApp
{
    partial class OperationProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationProductForm));
            this.gBox_PoductInfo = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.lblStockStatu = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.cmb_StockType = new System.Windows.Forms.ComboBox();
            this.cmb_Categories = new System.Windows.Forms.ComboBox();
            this.lst_OrderProduct = new System.Windows.Forms.ListBox();
            this.lblOrderProduct = new System.Windows.Forms.Label();
            this.gBox_PoductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_PoductInfo
            // 
            this.gBox_PoductInfo.Controls.Add(this.lblCategory);
            this.gBox_PoductInfo.Controls.Add(this.lblStockType);
            this.gBox_PoductInfo.Controls.Add(this.lblStockStatu);
            this.gBox_PoductInfo.Controls.Add(this.lblProductPrice);
            this.gBox_PoductInfo.Controls.Add(this.lblProductName);
            this.gBox_PoductInfo.Location = new System.Drawing.Point(18, 15);
            this.gBox_PoductInfo.Name = "gBox_PoductInfo";
            this.gBox_PoductInfo.Size = new System.Drawing.Size(133, 255);
            this.gBox_PoductInfo.TabIndex = 10;
            this.gBox_PoductInfo.TabStop = false;
            this.gBox_PoductInfo.Text = "Ürün Bilgileri";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 15);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Kategori :";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Location = new System.Drawing.Point(6, 144);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(59, 15);
            this.lblStockType.TabIndex = 12;
            this.lblStockType.Text = "Stok Tipi :";
            // 
            // lblStockStatu
            // 
            this.lblStockStatu.AutoSize = true;
            this.lblStockStatu.Location = new System.Drawing.Point(6, 115);
            this.lblStockStatu.Name = "lblStockStatu";
            this.lblStockStatu.Size = new System.Drawing.Size(83, 15);
            this.lblStockStatu.TabIndex = 11;
            this.lblStockStatu.Text = "Stok Durumu :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(6, 86);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(38, 15);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "Fiyat :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 57);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(28, 15);
            this.lblProductName.TabIndex = 9;
            this.lblProductName.Text = "Ad :";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(157, 127);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(203, 23);
            this.txt_Stock.TabIndex = 9;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(157, 98);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(203, 23);
            this.txt_Price.TabIndex = 8;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(157, 69);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(203, 23);
            this.txt_ProductName.TabIndex = 7;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddProduct.BackgroundImage")));
            this.btn_AddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddProduct.Location = new System.Drawing.Point(275, 186);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(85, 86);
            this.btn_AddProduct.TabIndex = 6;
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click_1);
            // 
            // cmb_StockType
            // 
            this.cmb_StockType.FormattingEnabled = true;
            this.cmb_StockType.Items.AddRange(new object[] {
            "Kg",
            "Litre",
            "Adet"});
            this.cmb_StockType.Location = new System.Drawing.Point(157, 156);
            this.cmb_StockType.Name = "cmb_StockType";
            this.cmb_StockType.Size = new System.Drawing.Size(203, 23);
            this.cmb_StockType.TabIndex = 11;
            // 
            // cmb_Categories
            // 
            this.cmb_Categories.FormattingEnabled = true;
            this.cmb_Categories.Location = new System.Drawing.Point(157, 40);
            this.cmb_Categories.Name = "cmb_Categories";
            this.cmb_Categories.Size = new System.Drawing.Size(203, 23);
            this.cmb_Categories.TabIndex = 12;
            this.cmb_Categories.SelectedIndexChanged += new System.EventHandler(this.cmb_Categories_SelectedIndexChanged);
            // 
            // lst_OrderProduct
            // 
            this.lst_OrderProduct.FormattingEnabled = true;
            this.lst_OrderProduct.ItemHeight = 15;
            this.lst_OrderProduct.Location = new System.Drawing.Point(367, 40);
            this.lst_OrderProduct.Name = "lst_OrderProduct";
            this.lst_OrderProduct.Size = new System.Drawing.Size(631, 229);
            this.lst_OrderProduct.TabIndex = 13;
            // 
            // lblOrderProduct
            // 
            this.lblOrderProduct.AutoSize = true;
            this.lblOrderProduct.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOrderProduct.Location = new System.Drawing.Point(365, 11);
            this.lblOrderProduct.Name = "lblOrderProduct";
            this.lblOrderProduct.Size = new System.Drawing.Size(187, 23);
            this.lblOrderProduct.TabIndex = 14;
            this.lblOrderProduct.Text = "Talep Edilenler";
            // 
            // OperationProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 281);
            this.Controls.Add(this.lblOrderProduct);
            this.Controls.Add(this.lst_OrderProduct);
            this.Controls.Add(this.cmb_Categories);
            this.Controls.Add(this.cmb_StockType);
            this.Controls.Add(this.gBox_PoductInfo);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.btn_AddProduct);
            this.Name = "OperationProductForm";
            this.Text = "Ürün  İşlemler Formu";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.gBox_PoductInfo.ResumeLayout(false);
            this.gBox_PoductInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_PoductInfo;
        private System.Windows.Forms.Label lblStockStatu;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.ComboBox cmb_StockType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmb_Categories;
        private System.Windows.Forms.ListBox lst_OrderProduct;
        private System.Windows.Forms.Label lblOrderProduct;
    }
}
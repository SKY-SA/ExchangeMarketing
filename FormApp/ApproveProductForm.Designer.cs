
namespace FormApp
{
    partial class ApproveProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveProductForm));
            this.btnApproveProduct = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.grpBox_Products = new System.Windows.Forms.GroupBox();
            this.lblApproveStatu = new System.Windows.Forms.Label();
            this.lblStockStatu = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblPoductId = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lst_UserId = new System.Windows.Forms.ListBox();
            this.lst_ApproveStatu = new System.Windows.Forms.ListBox();
            this.lst_UnitsInStock = new System.Windows.Forms.ListBox();
            this.lst_UnitPrice = new System.Windows.Forms.ListBox();
            this.lst_ProductName = new System.Windows.Forms.ListBox();
            this.lst_CategoryName = new System.Windows.Forms.ListBox();
            this.lst_CategoryId = new System.Windows.Forms.ListBox();
            this.lst_ProductId = new System.Windows.Forms.ListBox();
            this.grpBox_Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApproveProduct
            // 
            this.btnApproveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApproveProduct.BackgroundImage")));
            this.btnApproveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApproveProduct.Location = new System.Drawing.Point(864, 495);
            this.btnApproveProduct.Name = "btnApproveProduct";
            this.btnApproveProduct.Size = new System.Drawing.Size(141, 51);
            this.btnApproveProduct.TabIndex = 1;
            this.btnApproveProduct.Text = "Ürünü Onayla";
            this.btnApproveProduct.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnApproveProduct.UseVisualStyleBackColor = true;
            this.btnApproveProduct.Click += new System.EventHandler(this.btnApproveProduct_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.Location = new System.Drawing.Point(12, 495);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 51);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_List
            // 
            this.btn_List.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_List.BackgroundImage")));
            this.btn_List.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_List.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_List.Location = new System.Drawing.Point(741, 495);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(117, 51);
            this.btn_List.TabIndex = 3;
            this.btn_List.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // grpBox_Products
            // 
            this.grpBox_Products.Controls.Add(this.lblApproveStatu);
            this.grpBox_Products.Controls.Add(this.lblStockStatu);
            this.grpBox_Products.Controls.Add(this.lblProductPrice);
            this.grpBox_Products.Controls.Add(this.lblProductName);
            this.grpBox_Products.Controls.Add(this.lblCategoryName);
            this.grpBox_Products.Controls.Add(this.lblCategoryId);
            this.grpBox_Products.Controls.Add(this.lblPoductId);
            this.grpBox_Products.Controls.Add(this.lblUserId);
            this.grpBox_Products.Controls.Add(this.lst_UserId);
            this.grpBox_Products.Controls.Add(this.lst_ApproveStatu);
            this.grpBox_Products.Controls.Add(this.lst_UnitsInStock);
            this.grpBox_Products.Controls.Add(this.lst_UnitPrice);
            this.grpBox_Products.Controls.Add(this.lst_ProductName);
            this.grpBox_Products.Controls.Add(this.lst_CategoryName);
            this.grpBox_Products.Controls.Add(this.lst_CategoryId);
            this.grpBox_Products.Controls.Add(this.lst_ProductId);
            this.grpBox_Products.Location = new System.Drawing.Point(12, 12);
            this.grpBox_Products.Name = "grpBox_Products";
            this.grpBox_Products.Size = new System.Drawing.Size(993, 477);
            this.grpBox_Products.TabIndex = 6;
            this.grpBox_Products.TabStop = false;
            this.grpBox_Products.Text = "Ürünler";
            // 
            // lblApproveStatu
            // 
            this.lblApproveStatu.AutoSize = true;
            this.lblApproveStatu.Location = new System.Drawing.Point(843, 23);
            this.lblApproveStatu.Name = "lblApproveStatu";
            this.lblApproveStatu.Size = new System.Drawing.Size(82, 15);
            this.lblApproveStatu.TabIndex = 18;
            this.lblApproveStatu.Text = "Onay Durumu";
            // 
            // lblStockStatu
            // 
            this.lblStockStatu.AutoSize = true;
            this.lblStockStatu.Location = new System.Drawing.Point(696, 23);
            this.lblStockStatu.Name = "lblStockStatu";
            this.lblStockStatu.Size = new System.Drawing.Size(77, 15);
            this.lblStockStatu.TabIndex = 17;
            this.lblStockStatu.Text = "Stok Durumu";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(549, 23);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(64, 15);
            this.lblProductPrice.TabIndex = 16;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(338, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(58, 15);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(190, 23);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(76, 15);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Kategori İsmi";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(120, 23);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(64, 15);
            this.lblCategoryId.TabIndex = 13;
            this.lblCategoryId.Text = "Kategori Id";
            // 
            // lblPoductId
            // 
            this.lblPoductId.AutoSize = true;
            this.lblPoductId.Location = new System.Drawing.Point(64, 23);
            this.lblPoductId.Name = "lblPoductId";
            this.lblPoductId.Size = new System.Drawing.Size(46, 15);
            this.lblPoductId.TabIndex = 12;
            this.lblPoductId.Text = "Ürün Id";
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
            this.lst_UserId.Location = new System.Drawing.Point(64, 41);
            this.lst_UserId.Name = "lst_UserId";
            this.lst_UserId.Size = new System.Drawing.Size(58, 424);
            this.lst_UserId.TabIndex = 10;
            // 
            // lst_ApproveStatu
            // 
            this.lst_ApproveStatu.FormattingEnabled = true;
            this.lst_ApproveStatu.ItemHeight = 15;
            this.lst_ApproveStatu.Location = new System.Drawing.Point(843, 41);
            this.lst_ApproveStatu.Name = "lst_ApproveStatu";
            this.lst_ApproveStatu.Size = new System.Drawing.Size(145, 424);
            this.lst_ApproveStatu.TabIndex = 9;
            // 
            // lst_UnitsInStock
            // 
            this.lst_UnitsInStock.FormattingEnabled = true;
            this.lst_UnitsInStock.ItemHeight = 15;
            this.lst_UnitsInStock.Location = new System.Drawing.Point(696, 41);
            this.lst_UnitsInStock.Name = "lst_UnitsInStock";
            this.lst_UnitsInStock.Size = new System.Drawing.Size(146, 424);
            this.lst_UnitsInStock.TabIndex = 8;
            // 
            // lst_UnitPrice
            // 
            this.lst_UnitPrice.FormattingEnabled = true;
            this.lst_UnitPrice.ItemHeight = 15;
            this.lst_UnitPrice.Location = new System.Drawing.Point(549, 41);
            this.lst_UnitPrice.Name = "lst_UnitPrice";
            this.lst_UnitPrice.Size = new System.Drawing.Size(145, 424);
            this.lst_UnitPrice.TabIndex = 7;
            // 
            // lst_ProductName
            // 
            this.lst_ProductName.FormattingEnabled = true;
            this.lst_ProductName.ItemHeight = 15;
            this.lst_ProductName.Location = new System.Drawing.Point(338, 41);
            this.lst_ProductName.Name = "lst_ProductName";
            this.lst_ProductName.Size = new System.Drawing.Size(210, 424);
            this.lst_ProductName.TabIndex = 6;
            // 
            // lst_CategoryName
            // 
            this.lst_CategoryName.FormattingEnabled = true;
            this.lst_CategoryName.ItemHeight = 15;
            this.lst_CategoryName.Location = new System.Drawing.Point(180, 41);
            this.lst_CategoryName.Name = "lst_CategoryName";
            this.lst_CategoryName.Size = new System.Drawing.Size(157, 424);
            this.lst_CategoryName.TabIndex = 5;
            // 
            // lst_CategoryId
            // 
            this.lst_CategoryId.FormattingEnabled = true;
            this.lst_CategoryId.ItemHeight = 15;
            this.lst_CategoryId.Location = new System.Drawing.Point(122, 41);
            this.lst_CategoryId.Name = "lst_CategoryId";
            this.lst_CategoryId.Size = new System.Drawing.Size(58, 424);
            this.lst_CategoryId.TabIndex = 4;
            // 
            // lst_ProductId
            // 
            this.lst_ProductId.FormattingEnabled = true;
            this.lst_ProductId.ItemHeight = 15;
            this.lst_ProductId.Location = new System.Drawing.Point(6, 41);
            this.lst_ProductId.Name = "lst_ProductId";
            this.lst_ProductId.Size = new System.Drawing.Size(58, 424);
            this.lst_ProductId.TabIndex = 3;
            this.lst_ProductId.SelectedIndexChanged += new System.EventHandler(this.lst_ProductId_SelectedIndexChanged);
            // 
            // ApproveProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 558);
            this.Controls.Add(this.grpBox_Products);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btnApproveProduct);
            this.Name = "ApproveProductForm";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.ApproveProduct_Load);
            this.grpBox_Products.ResumeLayout(false);
            this.grpBox_Products.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApproveProduct;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.GroupBox grpBox_Products;
        private System.Windows.Forms.Label lblApproveStatu;
        private System.Windows.Forms.Label lblStockStatu;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblPoductId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.ListBox lst_UserId;
        private System.Windows.Forms.ListBox lst_ApproveStatu;
        private System.Windows.Forms.ListBox lst_UnitsInStock;
        private System.Windows.Forms.ListBox lst_UnitPrice;
        private System.Windows.Forms.ListBox lst_ProductName;
        private System.Windows.Forms.ListBox lst_CategoryName;
        private System.Windows.Forms.ListBox lst_CategoryId;
        private System.Windows.Forms.ListBox lst_ProductId;
    }
}
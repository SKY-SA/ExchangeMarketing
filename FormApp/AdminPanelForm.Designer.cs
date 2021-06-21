
namespace FormApp
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBox_operations = new System.Windows.Forms.GroupBox();
            this.lbl_AccountBalance = new System.Windows.Forms.Label();
            this.lblAccountant = new System.Windows.Forms.Label();
            this.btn_ApproveBalance = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btnApproveProduct = new System.Windows.Forms.Button();
            this.list_Id = new System.Windows.Forms.ListBox();
            this.grpBox_Products = new System.Windows.Forms.GroupBox();
            this.lbl_ApproveStatu = new System.Windows.Forms.Label();
            this.lblStockStatu = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lst_UserId = new System.Windows.Forms.ListBox();
            this.lst_ApproveStatu = new System.Windows.Forms.ListBox();
            this.lst_UnitsInStock = new System.Windows.Forms.ListBox();
            this.lst_UnitPrice = new System.Windows.Forms.ListBox();
            this.lst_ProductName = new System.Windows.Forms.ListBox();
            this.lst_CategoryName = new System.Windows.Forms.ListBox();
            this.lst_CategoryId = new System.Windows.Forms.ListBox();
            this.grpBox_operations.SuspendLayout();
            this.grpBox_Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(7, 419);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 63);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpBox_operations
            // 
            this.grpBox_operations.Controls.Add(this.lbl_AccountBalance);
            this.grpBox_operations.Controls.Add(this.lblAccountant);
            this.grpBox_operations.Controls.Add(this.btn_ApproveBalance);
            this.grpBox_operations.Controls.Add(this.btn_list);
            this.grpBox_operations.Controls.Add(this.btnApproveProduct);
            this.grpBox_operations.Controls.Add(this.btnBack);
            this.grpBox_operations.Location = new System.Drawing.Point(0, 0);
            this.grpBox_operations.Name = "grpBox_operations";
            this.grpBox_operations.Size = new System.Drawing.Size(205, 489);
            this.grpBox_operations.TabIndex = 1;
            this.grpBox_operations.TabStop = false;
            this.grpBox_operations.Text = "İşlemler";
            // 
            // lbl_AccountBalance
            // 
            this.lbl_AccountBalance.AutoSize = true;
            this.lbl_AccountBalance.Location = new System.Drawing.Point(122, 383);
            this.lbl_AccountBalance.Name = "lbl_AccountBalance";
            this.lbl_AccountBalance.Size = new System.Drawing.Size(19, 21);
            this.lbl_AccountBalance.TabIndex = 7;
            this.lbl_AccountBalance.Text = "0";
            // 
            // lblAccountant
            // 
            this.lblAccountant.AutoSize = true;
            this.lblAccountant.Location = new System.Drawing.Point(7, 381);
            this.lblAccountant.Name = "lblAccountant";
            this.lblAccountant.Size = new System.Drawing.Size(106, 21);
            this.lblAccountant.TabIndex = 6;
            this.lblAccountant.Text = "Muhasebeci :";
            // 
            // btn_ApproveBalance
            // 
            this.btn_ApproveBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ApproveBalance.BackgroundImage")));
            this.btn_ApproveBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ApproveBalance.Location = new System.Drawing.Point(0, 118);
            this.btn_ApproveBalance.Name = "btn_ApproveBalance";
            this.btn_ApproveBalance.Size = new System.Drawing.Size(199, 81);
            this.btn_ApproveBalance.TabIndex = 5;
            this.btn_ApproveBalance.Text = "Bakiye Onay";
            this.btn_ApproveBalance.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ApproveBalance.UseVisualStyleBackColor = true;
            this.btn_ApproveBalance.Click += new System.EventHandler(this.btn_ApproveBalance_Click);
            // 
            // btn_list
            // 
            this.btn_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_list.BackgroundImage")));
            this.btn_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_list.Location = new System.Drawing.Point(102, 419);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(93, 64);
            this.btn_list.TabIndex = 4;
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btnApproveProduct
            // 
            this.btnApproveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApproveProduct.BackgroundImage")));
            this.btnApproveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApproveProduct.Location = new System.Drawing.Point(0, 28);
            this.btnApproveProduct.Name = "btnApproveProduct";
            this.btnApproveProduct.Size = new System.Drawing.Size(199, 84);
            this.btnApproveProduct.TabIndex = 3;
            this.btnApproveProduct.Text = "Ürün Onayla";
            this.btnApproveProduct.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnApproveProduct.UseVisualStyleBackColor = true;
            this.btnApproveProduct.Click += new System.EventHandler(this.btnApproveProduct_Click);
            // 
            // list_Id
            // 
            this.list_Id.FormattingEnabled = true;
            this.list_Id.ItemHeight = 21;
            this.list_Id.Location = new System.Drawing.Point(68, 41);
            this.list_Id.Name = "list_Id";
            this.list_Id.Size = new System.Drawing.Size(93, 445);
            this.list_Id.TabIndex = 3;
            // 
            // grpBox_Products
            // 
            this.grpBox_Products.Controls.Add(this.lbl_ApproveStatu);
            this.grpBox_Products.Controls.Add(this.lblStockStatu);
            this.grpBox_Products.Controls.Add(this.lblProductPrice);
            this.grpBox_Products.Controls.Add(this.lblProductName);
            this.grpBox_Products.Controls.Add(this.lblCategoryName);
            this.grpBox_Products.Controls.Add(this.lblCategoryId);
            this.grpBox_Products.Controls.Add(this.lblProductId);
            this.grpBox_Products.Controls.Add(this.lblUserId);
            this.grpBox_Products.Controls.Add(this.lst_UserId);
            this.grpBox_Products.Controls.Add(this.lst_ApproveStatu);
            this.grpBox_Products.Controls.Add(this.lst_UnitsInStock);
            this.grpBox_Products.Controls.Add(this.lst_UnitPrice);
            this.grpBox_Products.Controls.Add(this.lst_ProductName);
            this.grpBox_Products.Controls.Add(this.lst_CategoryName);
            this.grpBox_Products.Controls.Add(this.lst_CategoryId);
            this.grpBox_Products.Controls.Add(this.list_Id);
            this.grpBox_Products.Location = new System.Drawing.Point(211, 0);
            this.grpBox_Products.Name = "grpBox_Products";
            this.grpBox_Products.Size = new System.Drawing.Size(993, 489);
            this.grpBox_Products.TabIndex = 4;
            this.grpBox_Products.TabStop = false;
            this.grpBox_Products.Text = "Ürünler";
            // 
            // lbl_ApproveStatu
            // 
            this.lbl_ApproveStatu.AutoSize = true;
            this.lbl_ApproveStatu.Location = new System.Drawing.Point(866, 18);
            this.lbl_ApproveStatu.Name = "lbl_ApproveStatu";
            this.lbl_ApproveStatu.Size = new System.Drawing.Size(109, 21);
            this.lbl_ApproveStatu.TabIndex = 18;
            this.lbl_ApproveStatu.Text = "Onay Durumu";
            // 
            // lblStockStatu
            // 
            this.lblStockStatu.AutoSize = true;
            this.lblStockStatu.Location = new System.Drawing.Point(729, 19);
            this.lblStockStatu.Name = "lblStockStatu";
            this.lblStockStatu.Size = new System.Drawing.Size(105, 21);
            this.lblStockStatu.TabIndex = 17;
            this.lblStockStatu.Text = "Stok Durumu";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(603, 19);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(87, 21);
            this.lblProductPrice.TabIndex = 16;
            this.lblProductPrice.Text = "Ürün Fiyatı";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(419, 19);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 21);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Ürün İsmi";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(272, 19);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(107, 21);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Kategori İsmi";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(169, 19);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(92, 21);
            this.lblCategoryId.TabIndex = 13;
            this.lblCategoryId.Text = "Kategori Id";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(68, 19);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(64, 21);
            this.lblProductId.TabIndex = 12;
            this.lblProductId.Text = "Ürün Id";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(6, 19);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(56, 21);
            this.lblUserId.TabIndex = 11;
            this.lblUserId.Text = "Kul. Id";
            // 
            // lst_UserId
            // 
            this.lst_UserId.FormattingEnabled = true;
            this.lst_UserId.ItemHeight = 21;
            this.lst_UserId.Location = new System.Drawing.Point(6, 41);
            this.lst_UserId.Name = "lst_UserId";
            this.lst_UserId.Size = new System.Drawing.Size(58, 445);
            this.lst_UserId.TabIndex = 10;
            // 
            // lst_ApproveStatu
            // 
            this.lst_ApproveStatu.FormattingEnabled = true;
            this.lst_ApproveStatu.ItemHeight = 21;
            this.lst_ApproveStatu.Location = new System.Drawing.Point(866, 41);
            this.lst_ApproveStatu.Name = "lst_ApproveStatu";
            this.lst_ApproveStatu.Size = new System.Drawing.Size(127, 445);
            this.lst_ApproveStatu.TabIndex = 9;
            // 
            // lst_UnitsInStock
            // 
            this.lst_UnitsInStock.FormattingEnabled = true;
            this.lst_UnitsInStock.ItemHeight = 21;
            this.lst_UnitsInStock.Location = new System.Drawing.Point(729, 41);
            this.lst_UnitsInStock.Name = "lst_UnitsInStock";
            this.lst_UnitsInStock.Size = new System.Drawing.Size(131, 445);
            this.lst_UnitsInStock.TabIndex = 8;
            // 
            // lst_UnitPrice
            // 
            this.lst_UnitPrice.FormattingEnabled = true;
            this.lst_UnitPrice.ItemHeight = 21;
            this.lst_UnitPrice.Location = new System.Drawing.Point(603, 41);
            this.lst_UnitPrice.Name = "lst_UnitPrice";
            this.lst_UnitPrice.Size = new System.Drawing.Size(120, 445);
            this.lst_UnitPrice.TabIndex = 7;
            // 
            // lst_ProductName
            // 
            this.lst_ProductName.FormattingEnabled = true;
            this.lst_ProductName.ItemHeight = 21;
            this.lst_ProductName.Location = new System.Drawing.Point(419, 41);
            this.lst_ProductName.Name = "lst_ProductName";
            this.lst_ProductName.Size = new System.Drawing.Size(178, 445);
            this.lst_ProductName.TabIndex = 6;
            // 
            // lst_CategoryName
            // 
            this.lst_CategoryName.FormattingEnabled = true;
            this.lst_CategoryName.ItemHeight = 21;
            this.lst_CategoryName.Location = new System.Drawing.Point(272, 41);
            this.lst_CategoryName.Name = "lst_CategoryName";
            this.lst_CategoryName.Size = new System.Drawing.Size(141, 445);
            this.lst_CategoryName.TabIndex = 5;
            // 
            // lst_CategoryId
            // 
            this.lst_CategoryId.FormattingEnabled = true;
            this.lst_CategoryId.ItemHeight = 21;
            this.lst_CategoryId.Location = new System.Drawing.Point(169, 41);
            this.lst_CategoryId.Name = "lst_CategoryId";
            this.lst_CategoryId.Size = new System.Drawing.Size(97, 445);
            this.lst_CategoryId.TabIndex = 4;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 501);
            this.Controls.Add(this.grpBox_Products);
            this.Controls.Add(this.grpBox_operations);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "AdminPanelForm";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.grpBox_operations.ResumeLayout(false);
            this.grpBox_operations.PerformLayout();
            this.grpBox_Products.ResumeLayout(false);
            this.grpBox_Products.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpBox_operations;
        private System.Windows.Forms.Button btnApproveProduct;
        private System.Windows.Forms.ListBox list_Id;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_ApproveBalance;
        private System.Windows.Forms.GroupBox grpBox_Products;
        private System.Windows.Forms.ListBox lst_CategoryId;
        private System.Windows.Forms.ListBox lst_CategoryName;
        private System.Windows.Forms.ListBox lst_ProductName;
        private System.Windows.Forms.ListBox lst_UnitPrice;
        private System.Windows.Forms.ListBox lst_UnitsInStock;
        private System.Windows.Forms.ListBox lst_ApproveStatu;
        private System.Windows.Forms.ListBox lst_UserId;
        private System.Windows.Forms.Label lbl_ApproveStatu;
        private System.Windows.Forms.Label lblStockStatu;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lbl_AccountBalance;
        private System.Windows.Forms.Label lblAccountant;
    }
}
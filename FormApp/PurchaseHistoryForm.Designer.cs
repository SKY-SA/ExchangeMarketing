
namespace AppInterface
{
    partial class PurchaseHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseHistoryForm));
            this.lst_PurchaseHistory = new System.Windows.Forms.ListBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.lblPurchaseHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_PurchaseHistory
            // 
            this.lst_PurchaseHistory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lst_PurchaseHistory.FormattingEnabled = true;
            this.lst_PurchaseHistory.ItemHeight = 15;
            this.lst_PurchaseHistory.Location = new System.Drawing.Point(12, 79);
            this.lst_PurchaseHistory.Name = "lst_PurchaseHistory";
            this.lst_PurchaseHistory.Size = new System.Drawing.Size(776, 364);
            this.lst_PurchaseHistory.TabIndex = 0;
            // 
            // btn_Export
            // 
            this.btn_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.BackgroundImage")));
            this.btn_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Export.Location = new System.Drawing.Point(647, 449);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(141, 97);
            this.btn_Export.TabIndex = 1;
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // lblPurchaseHistory
            // 
            this.lblPurchaseHistory.AutoSize = true;
            this.lblPurchaseHistory.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPurchaseHistory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPurchaseHistory.Location = new System.Drawing.Point(-5, -6);
            this.lblPurchaseHistory.Name = "lblPurchaseHistory";
            this.lblPurchaseHistory.Size = new System.Drawing.Size(767, 82);
            this.lblPurchaseHistory.TabIndex = 2;
            this.lblPurchaseHistory.Text = "Alım Satım Geçmişi";
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lblPurchaseHistory);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.lst_PurchaseHistory);
            this.Name = "PurchaseHistoryForm";
            this.Text = "Alım Satım Geçmiş Formu";
            this.Load += new System.EventHandler(this.PurchaseHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_PurchaseHistory;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label lblPurchaseHistory;
    }
}

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
            this.dTime_Before = new System.Windows.Forms.DateTimePicker();
            this.dTime_After = new System.Windows.Forms.DateTimePicker();
            this.btn_GetFilter = new System.Windows.Forms.Button();
            this.lblDateTimeBefore = new System.Windows.Forms.Label();
            this.lblDateTimeAfter = new System.Windows.Forms.Label();
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
            // dTime_Before
            // 
            this.dTime_Before.Location = new System.Drawing.Point(12, 483);
            this.dTime_Before.Name = "dTime_Before";
            this.dTime_Before.Size = new System.Drawing.Size(184, 23);
            this.dTime_Before.TabIndex = 3;
            // 
            // dTime_After
            // 
            this.dTime_After.Location = new System.Drawing.Point(215, 484);
            this.dTime_After.Name = "dTime_After";
            this.dTime_After.Size = new System.Drawing.Size(184, 23);
            this.dTime_After.TabIndex = 4;
            // 
            // btn_GetFilter
            // 
            this.btn_GetFilter.Location = new System.Drawing.Point(478, 449);
            this.btn_GetFilter.Name = "btn_GetFilter";
            this.btn_GetFilter.Size = new System.Drawing.Size(163, 94);
            this.btn_GetFilter.TabIndex = 5;
            this.btn_GetFilter.Text = "Filtrele";
            this.btn_GetFilter.UseVisualStyleBackColor = true;
            this.btn_GetFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDateTimeBefore
            // 
            this.lblDateTimeBefore.AutoSize = true;
            this.lblDateTimeBefore.Location = new System.Drawing.Point(12, 465);
            this.lblDateTimeBefore.Name = "lblDateTimeBefore";
            this.lblDateTimeBefore.Size = new System.Drawing.Size(89, 15);
            this.lblDateTimeBefore.TabIndex = 6;
            this.lblDateTimeBefore.Text = "Başlangıç Tarihi";
            // 
            // lblDateTimeAfter
            // 
            this.lblDateTimeAfter.AutoSize = true;
            this.lblDateTimeAfter.Location = new System.Drawing.Point(215, 466);
            this.lblDateTimeAfter.Name = "lblDateTimeAfter";
            this.lblDateTimeAfter.Size = new System.Drawing.Size(61, 15);
            this.lblDateTimeAfter.TabIndex = 7;
            this.lblDateTimeAfter.Text = "Biriş Tarihi";
            // 
            // PurchaseHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.lblDateTimeAfter);
            this.Controls.Add(this.lblDateTimeBefore);
            this.Controls.Add(this.btn_GetFilter);
            this.Controls.Add(this.dTime_After);
            this.Controls.Add(this.dTime_Before);
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
        private System.Windows.Forms.DateTimePicker dTime_Before;
        private System.Windows.Forms.DateTimePicker dTime_After;
        private System.Windows.Forms.Button btn_GetFilter;
        private System.Windows.Forms.Label lblDateTimeBefore;
        private System.Windows.Forms.Label lblDateTimeAfter;
    }
}
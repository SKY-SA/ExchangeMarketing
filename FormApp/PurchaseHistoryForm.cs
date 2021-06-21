using Business.Concrete;
using System;
using System.Windows.Forms;
using exportToWord = Microsoft.Office.Interop.Word;

namespace AppInterface
{
    public partial class PurchaseHistoryForm : Form
    {
        public PurchaseHistoryForm()
        {
            InitializeComponent();
        }
        internal OrderProductManager orderProductManager;
        internal CategoryManager categoryManager;
        internal UserManager userManager;
        internal int userId;
        int chosenYear = 0;
        int chosenMonth = 0;
        int chosenDay = 0;

        string categoryName = "";
        string productName = "";
        string productDemandPrice = "";
        string purchaseTime = "";
        string productDemandQuantity = "";
        string totalpayable = "";
        string productStockType = "";
        private void PurchaseHistoryForm_Load(object sender, EventArgs e)
        {
            lst_PurchaseHistory.Items.Clear();
            // Satım yapılan ürünlerin listesine ulaşma
            foreach (var successedOrderProduct in orderProductManager.GetList_SuccessedBuy())
            { 
             
                //Ürünlerin detaylarına ulaşma
                foreach (var detailOrderProduct in orderProductManager.GetDetailsOfProduct(categoryManager.GetList()))
                {
                    // satım yapılan ile detaylarına ulaşılan ürünlerin id'leri aynı mı kontrol
                    if (successedOrderProduct.ProductId == detailOrderProduct.ProductId)
                    {
                        //Alıcı mı 
                        if (detailOrderProduct.ReceiverId == userId)
                        {
                            DefineTheVariables(detailOrderProduct);
                            lst_PurchaseHistory.Items.Add("Kategori ismi: " + detailOrderProduct.CategoryName + "  Ürün Adı: " + detailOrderProduct.ProductName + " Alım Fiyatı: "
                                + detailOrderProduct.DemandPrice + " Adet: " + detailOrderProduct.DemandQuantity + " " + detailOrderProduct.StockType
                                + "  Ödenen Tutar: " + totalpayable+ " --->Alım Tarihi: " + detailOrderProduct.Time);
                        }
                        //Satıcı mı 
                        else if (detailOrderProduct.UserId == userId)
                        {
                            DefineTheVariables(detailOrderProduct);
                            lst_PurchaseHistory.Items.Add("Kategori ismi: " + detailOrderProduct.CategoryName + "  Ürün Adı: " + detailOrderProduct.ProductName + " Satış Fiyatı: " 
                                + detailOrderProduct.DemandPrice + " Adet: " + detailOrderProduct.DemandQuantity + " " + detailOrderProduct.StockType + " Alınan Tutar: "
                                + detailOrderProduct.DemandPrice*detailOrderProduct.DemandQuantity + " --->Satış Tarihi: " + detailOrderProduct.Time);
                        }
                    }
                }
            }
        }

        private void DefineTheVariables(Entities.DTOs.PurchaseHistoryProductDto orderProduct)
        {
            categoryName = orderProduct.CategoryName; 
            productName = orderProduct.ProductName;
            productDemandPrice = orderProduct.DemandPrice.ToString(); 
            productStockType = orderProduct.StockType;
            productDemandQuantity = orderProduct.DemandQuantity.ToString(); 
            totalpayable = orderProduct.TotalPaybleAmount.ToString(); 
            purchaseTime = orderProduct.Time.ToString();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            
                //Word Başlatılıyoruz.
                exportToWord.Application objWord = new exportToWord.Application();
                objWord.Visible = true;
                exportToWord.Document objDoc;
                //Yeni word belgesi oluşturuyoruz.
                object objMissing = System.Reflection.Missing.Value;
                objDoc = objWord.Documents.Add(ref objMissing);

               
                objWord.Selection.Font.Size = 12;
                objWord.Selection.Font.Name = "Arial";
            // Yazdıracağımız metni gönderiyoruz .
            for (int i = 0; i < lst_PurchaseHistory.Items.Count; i++)
            {
                objWord.ActiveWindow.Selection.TypeText("\t\t\t ~~~~~~~~Alım Satım Geçmişi~~~~~~~~ \n" + lst_PurchaseHistory.Text);
            }
               
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            chosenYear = dTime_Before.Value.Year - dTime_After.Value.Year;
            chosenMonth = dTime_After.Value.Month - dTime_After.Value.Month;
            chosenDay = dTime_After.Value.Day - dTime_After.Value.Day;

            lst_PurchaseHistory.Items.Clear();
            // Satım yapılan ürünlerin listesine ulaşma
            foreach (var successedOrderProduct in orderProductManager.GetList_SuccessedBuy())
            {
                
                //Ürünlerin detaylarına ulaşma
                foreach (var detailOrderProduct in orderProductManager.GetDetailsOfProduct(categoryManager.GetList()))
                {
                    // satım yapılan ile detaylarına ulaşılan ürünlerin id'leri aynı mı kontrol
                    if ((successedOrderProduct.ProductId == detailOrderProduct.ProductId) )
                    {
                        var result1 = DateTime.Compare( dTime_Before.Value, detailOrderProduct.Time);
                       
                        var result2 = DateTime.Compare( detailOrderProduct.Time, dTime_After.Value);
                        if ((result1 <= 0) && (result2 <= 0))
                        {
                            //Alıcı mı 
                            if (detailOrderProduct.ReceiverId == userId)
                            {
                                DefineTheVariables(detailOrderProduct);
                                lst_PurchaseHistory.Items.Add("Kategori ismi: " + detailOrderProduct.CategoryName + "  Ürün Adı: " + detailOrderProduct.ProductName + " Alım Fiyatı: "
                                    + detailOrderProduct.DemandPrice + " Adet: " + detailOrderProduct.DemandQuantity + " " + detailOrderProduct.StockType
                                    + "  Ödenen Tutar: " + totalpayable + " --->Alım Tarihi: " + detailOrderProduct.Time);

                            }
                            //Satıcı mı 
                            else if (detailOrderProduct.UserId == userId && (successedOrderProduct.Time.Day >= chosenDay) && (successedOrderProduct.Time.Month >= chosenMonth) && (successedOrderProduct.Time.Year >= chosenYear))
                            {
                                DefineTheVariables(detailOrderProduct);
                                lst_PurchaseHistory.Items.Add("Kategori ismi: " + detailOrderProduct.CategoryName + "  Ürün Adı: " + detailOrderProduct.ProductName + " Satış Fiyatı: "
                                    + detailOrderProduct.DemandPrice + " Adet: " + detailOrderProduct.DemandQuantity + " " + detailOrderProduct.StockType + " Alınan Tutar: "
                                    + detailOrderProduct.DemandPrice * detailOrderProduct.DemandQuantity + " --->Satış Tarihi: " + detailOrderProduct.Time);
                            }
                        }
                    }
                }
            }

        }
    }
}

using Business.Concrete;
using System;
using System.Windows.Forms;
using System.Xml;

namespace FormApp
{
    public partial class ApproveBalanceForm : Form
    {
        internal UserManager userManager;
        int choosenUserId;
        double sellEuro = 0;
        double sellUsd = 0;
        
        public ApproveBalanceForm()
        {
            InitializeComponent();
        }
        //Döviz kurlarının çekileceği sabit url adresi 
        const string todayExchange = "https://www.tcmb.gov.tr/kurlar/today.xml";
        private void ApproveBalance_Load(object sender, EventArgs e)
        {
            ListOfBalanceToApproveList();
            UpdateTheExchange();
        }
        //Belirtilen sitye gidip kur fiyatlarını çeken fonksiyon
        private void UpdateTheExchange()
        {
            var cxml = new XmlDocument();
            cxml.Load(todayExchange);

            DateTime dt = Convert.ToDateTime(cxml.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            lblDateNow.Text = dt.ToString();

             string strSellUsd= cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'USD']/BanknoteSelling").InnerXml;
            

            strSellUsd = strSellUsd.Replace(".", ",");
            lbl_SellUsd.Text = strSellUsd;
            sellUsd = Convert.ToDouble(lbl_SellUsd.Text);
            

            string strSellEuro = cxml.SelectSingleNode("Tarih_Date/Currency [@Kod = 'EUR']/BanknoteSelling").InnerXml;

            strSellEuro = strSellEuro.Replace(".", ",");
            lbl_SellEuro.Text = strSellEuro;
            sellEuro = Convert.ToDouble(lbl_SellEuro.Text);

            

        }
        // Bakiye Ekleyenleri listeleyen Fonksiyon
        private void ListOfBalanceToApproveList()
        {
            lstId.Items.Clear();
            lstBalance.Items.Clear();
            lst_MoneyType.Items.Clear();
            foreach (var user in userManager.GetList())
            {
                if (user.BalanceApprove == false)
                {
                    lstId.Items.Add(user.UserId);
                    lstBalance.Items.Add(user.AddBalance);
                    lst_MoneyType.Items.Add(user.AddedBalanceType);

                }
            }
            btn_Accept.Enabled = false;
        }

        private void lstId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choosenUserId = 0;
            if(lstId.SelectedIndex != -1)
            {
                choosenUserId = Convert.ToInt32(lstId.SelectedItem.ToString());
                btn_Accept.Enabled = true;
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            double moneyToTotalAdded = 0;
            if (lstId.SelectedIndex != -1)
            {
                foreach (var user in userManager.GetList())
                {
                    
                     if (user.UserId == choosenUserId && (user.AddedBalanceType == "Türk Lirası"))
                    {
                        moneyToTotalAdded = user.AddBalance;
                        txt_ExchangeAmount.Text = user.AddBalance.ToString();
                        user.Balance += user.AddBalance;
                        user.AddBalance = 0;
                        user.AddedBalanceType = "";
                        user.BalanceApprove = true;
                        MessageBox.Show("Bakiye Onaylama başarılı bir şekilde yapılmıştır.");
                    }
                    else if ((user.UserId == choosenUserId) && (user.AddedBalanceType == "Dolar"))
                    {
                        moneyToTotalAdded = (user.AddBalance * sellUsd);
                        txt_ExchangeAmount.Text = moneyToTotalAdded.ToString();
                        user.Balance += moneyToTotalAdded;
                        user.AddBalance = 0;
                        user.AddedBalanceType = "";
                        user.BalanceApprove = true;
                        MessageBox.Show("Bakiye Onaylama başarılı bir şekilde yapılmıştır."+ " ");
                    }
                    else if ((user.UserId == choosenUserId) && (user.AddedBalanceType == "Euro"))
                    {
                        moneyToTotalAdded = (user.AddBalance * sellEuro);
                        txt_ExchangeAmount.Text =moneyToTotalAdded.ToString();
                        user.Balance += moneyToTotalAdded;
                        user.AddedBalanceType = "";
                        user.AddBalance = 0;
                        user.BalanceApprove = true;
                        MessageBox.Show("Bakiye Onaylama başarılı bir şekilde yapılmıştır.");
                    }
                }
                ListOfBalanceToApproveList();

            }
        }
    }
}

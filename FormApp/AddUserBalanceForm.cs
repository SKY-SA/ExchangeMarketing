using Business.Constants;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormApp
{
    public partial class AddUserBalanceForm : Form
    {
        public AddUserBalanceForm()
        {
            InitializeComponent();
        }
        internal User user;
        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(moneyType)) && (txt_PriceToAdd != null))
            {
                user.AddBalance = Convert.ToDouble(txt_PriceToAdd.Text);
                //Eklenen bakiyenin admin formunda onaylanacak bakiyeler arasında gözükmesi için
                user.BalanceApprove = false;
                user.AddedBalanceType = moneyType;
                MessageBox.Show(user.AddBalance.ToString() + " " +moneyType+"\n" + Messages.AddedBalance);
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş bırakmayınız");
            }
            
        }
        string moneyType = "";
        private void AddUserBalance_Load(object sender, EventArgs e)
        {
            btn_Accept.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn_Accept.Enabled = true;
        }

        private void cmb_MoneyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_MoneyType.SelectedIndex != -1)
            {
                moneyType = cmb_MoneyType.SelectedItem.ToString();
            }
        }
    }
}

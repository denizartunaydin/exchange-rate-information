using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exchange_Rate_Information
{
    public partial class frm_currency : Form
    {
        public frm_currency()
        {
            InitializeComponent();
        }

        private void frm_currency_Load(object sender, EventArgs e)
        {
            List<string> currencies = new List<string>() { "USD", "EUR", "AUD", "DKK", "GBP", "CHF", "SEK", "CAD", "KWD", "NOK", "SAR", " JPY", "BGN", "RON", "RUB", "IRR", "CNY", "PKR", "QAR" };

            foreach (var currency in currencies)
            {
                cmb_currencies.Items.Add(currency);
            }
        }

        string get_currency_buying(string type, DateTime time)
        {
            string day;

            if (time != null)
            {
                day = "https://www.tcmb.gov.tr/kurlar/" + time.ToString("yyyy") + time.ToString("MM") + "/" + time.ToString("dd") + time.ToString("MM") + time.ToString("yyyy") + ".xml";
            }
            else
            {
                day = "https://www.tcmb.gov.tr/kurlar/today.xml";
            }

            var xmldoc = new XmlDocument();

            try
            {
                lbl_error.Visible = false;
                xmldoc.Load(day);
                var result = xmldoc.SelectSingleNode(String.Format("Tarih_Date/Currency [@Kod='{0}']/ForexBuying", type)).InnerXml;
                return result.Replace(".", ",");
            }
            catch (WebException)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Seçilen Tarihte Satış veya Alış Kuru Bulunamadı";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           

            return "0";
        }

        string get_currency_selling(string type, DateTime time)
        {
            string day;

            if (time != null)
            {
                day = "https://www.tcmb.gov.tr/kurlar/" + time.ToString("yyyy") + time.ToString("MM") + "/" + time.ToString("dd") + time.ToString("MM") + time.ToString("yyyy") + ".xml";
            }
            else
            {
                day = "https://www.tcmb.gov.tr/kurlar/today.xml";
            }

            var xmldoc = new XmlDocument();

            try
            {
                lbl_error.Visible = false;
                xmldoc.Load(day);
                var result = xmldoc.SelectSingleNode(String.Format("Tarih_Date/Currency [@Kod='{0}']/ForexSelling", type)).InnerXml;
                return result.Replace(".", ",");
            }
            catch (WebException)
            {
                lbl_error.Visible = true;
                lbl_error.Text = "Seçilen Tarihte Satış veya Alış Kuru Bulunamadı";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return "0";
        }

        private void cmb_currencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_change();
        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            item_change();
        }

        void item_change()
        {
            if (cmb_currencies.Text != null && cmb_currencies.Text != "")
            {
                if (datetime.Value != null)
                {
                    lbl_buying.Text = get_currency_buying(cmb_currencies.Text, datetime.Value) + " TL";
                    lbl_selling.Text = get_currency_selling(cmb_currencies.Text, datetime.Value) + " TL";
                }
                else
                {
                    MessageBox.Show("Tarih lanını gerekli şekilde doldurunuz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                              
            }
            else
            {
                MessageBox.Show("Kur alanını gerekli şekilde doldurunuz !","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }        
    }
}

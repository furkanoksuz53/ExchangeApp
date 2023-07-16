using Newtonsoft.Json;
using System.Xml;

namespace ExchangeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kur, miktar, tutar, kalan;
        public class Currency
        {
            public string CurrencyCode { get; set; }
            public string CurrencyName { get; set; }
            public string Alis { get; set; }
            public string Satis { get; set; }

        }
        List<Currency> currencyList = new List<Currency>();

        public void KurlariGetir()
        {
            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";

            using (HttpClient client = new HttpClient())
            {
                // HTTP isteði yapma
                HttpResponseMessage response = client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string xmlData = response.Content.ReadAsStringAsync().Result;

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(xmlData);


                    XmlNodeList currencyNodes = xmlDoc.SelectNodes("//Currency");
                    foreach (XmlNode currencyNode in currencyNodes)
                    {
                        Currency currency = new Currency
                        {
                            CurrencyCode = currencyNode.Attributes["CurrencyCode"].Value,
                            CurrencyName = currencyNode.SelectSingleNode("CurrencyName").InnerText,
                            Alis = currencyNode.SelectSingleNode("ForexBuying").InnerXml,
                            Satis = currencyNode.SelectSingleNode("ForexSelling").InnerXml
                        };
                        currencyList.Add(currency);
                    }

                }
                else
                {
                    Console.WriteLine("HTTP isteði baþarýsýz oldu. Hata kodu: " + response.StatusCode);
                }
            }
            foreach (var currency in currencyList)
            {
                if (currency.Alis.Length>0 && currency.Satis.Length > 0)
                {
                    dataGridView1.Rows.Add(currency.CurrencyCode, currency.Alis, currency.Satis);

                    comboBox1.Items.Add(currency.CurrencyCode);
                }
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KurlariGetir();
        }

        private void btnHesapla1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxMiktar.Text.Length > 0)
                {
                    Hesapla1();
                }
                else
                {
                    MessageBox.Show("Lütfen miktarý giriniz");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz");
            }

        }
        private void btnHesapla2_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(tbxTutar.Text);
                if (tbxTutar.Text.Length > 0)
                {
                    Hesapla2();
                }
                else
                {
                    MessageBox.Show("Lütfen tutarý giriniz");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz");
            }


        }
        public void Hesapla1()
        {
            kur = Convert.ToDouble(tbxKur.Text);
            miktar = Convert.ToDouble(tbxMiktar.Text);
            tutar = kur * miktar;
            tbxTutar.Text = tutar.ToString();
        }
        public void Hesapla2()
        {
            kur = Convert.ToDouble(tbxKur.Text);
            tutar = Convert.ToDouble(tbxTutar.Text);
            int miktar2 = Convert.ToInt32(tutar / kur);
            tbxMiktar.Text = miktar2.ToString();
            kalan = tutar - kur * miktar2;
            tbxKalan.Text = kalan.ToString("N" + 2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency curreny = new Currency();
            curreny = currencyList.Where(x => x.CurrencyCode == comboBox1.SelectedItem.ToString()).First();
            lblAlis.Text = curreny.Alis;
            lblSatis.Text= curreny.Satis;
        }

        private void btnAlis_Click(object sender, EventArgs e)
        {
            tbxKur.Text = lblAlis.Text.Replace('.', ',');
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            tbxKur.Text = lblSatis.Text.Replace('.', ',');

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblAlis.Text = dataGridView1.Rows[e.RowIndex].Cells["AlisFiyati"].Value.ToString();
            lblSatis.Text = dataGridView1.Rows[e.RowIndex].Cells["SatisFiyati"].Value.ToString();

        }
    }
}

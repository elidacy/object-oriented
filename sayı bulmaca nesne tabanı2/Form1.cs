using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayı_bulmaca_nesne_tabanı2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hedef_sayi;
        private void sayi_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            hedef_sayi =r.Next(100, 999);
            lahedefsayi.Text = hedef_sayi.ToString();
        }

        private void lbrakamlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //listboxtan bir eleman seçilmiş ise
            if(lbrakamlar.SelectedIndex >= 0)
            {
                // 1. textbox boş ise oraya değilse 2.text box a sayıyı yazıp
                // listboxtan ilgili sayıyı çıkart..
                if(tbsayi1.Text == "")
                {
                    tbsayi1.Text = lbrakamlar.SelectedItem.ToString();
                    int secilen;
                    secilen = lbrakamlar.SelectedIndex;
                    lbrakamlar.Items.RemoveAt(secilen);
                }
                else if (tbsayi2.Text == "")
                {
                    tbsayi2.Text = lbrakamlar.SelectedItem.ToString();
                    int secilen;
                    secilen = lbrakamlar.SelectedIndex;
                    lbrakamlar.Items.RemoveAt(secilen);
                }
            }
        }

        private void btsonuc_Click(object sender, EventArgs e)
        {
            char islem = Convert.ToChar(lbislem.SelectedItem);

            int sonuc = 0, sayi1, sayi2;
            sayi1 = Convert.ToInt32(tbsayi1.Text);
            sayi2 = Convert.ToInt32(tbsayi2.Text);

            switch (islem)
            {
                case '+': sonuc = sayi1 + sayi2; break;
                case '-': sonuc = sayi1 - sayi2; break;
                case '*': sonuc = sayi1 * sayi2; break;
                case '/': sonuc = sayi1 / sayi2; break;
                default: MessageBox.Show("bir işem seçmediniz:");break;

            }
            lbrakamlar.Items.Add(sonuc);
            tbsayi1.Text = "";
            tbsayi2.Text = "";
        }
    }
}

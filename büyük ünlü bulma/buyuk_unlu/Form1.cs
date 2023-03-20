using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buyuk_unlu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool kalin_varmi(string kelime)
        {
            bool var = false;
            for (int i = 0; i < kelime.Length; i++)
                if (kelime[i] == 'a' || kelime[i] == 'ı' ||
                    kelime[i] == 'o' || kelime[i] == 'u')
                {
                    var = true;
                    break;
                }
            return var;
        }

        bool ince_varmi(string kelime)
        {
            bool var = false;
            for (int i = 0; i < kelime.Length; i++)
                if (kelime[i] == 'e' || kelime[i] == 'i' ||
                    kelime[i] == 'ö' || kelime[i] == 'ü')
                {
                    var = true;
                    break;
                }
            return var;
        }

        bool uyuyor_mu(string kelime)
        {
            bool ince, kalin;
            kelime = kelime.ToLower();
            ince = ince_varmi(kelime);
            kalin = kalin_varmi(kelime);

            if ((kalin == true && ince == true) || (kalin == false && ince == false))
                return false;
            else
                return true;
        }

        private void btBul_Click(object sender, EventArgs e)
        {
            //textboxtaki metni boşluğa göre parçalayıp bir dizinin 
            //içerisine atıyoruz
            string [] kelimeler = rtbMetin.Text.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
                if (uyuyor_mu(kelimeler[i]) == true)
                    lbUyan.Items.Add(kelimeler[i]);
                else
                    lbUymayan.Items.Add(kelimeler[i]);
        }
    }
}

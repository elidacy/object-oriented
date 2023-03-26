using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace çizim_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x_bas, y_bas;

        void dortgen_ciz(int x, int y, int gen, int yuk, bool dolumu, int kalinlik, Color renk)
        {
            //fomun çizim olaylarını ve özelliklerini
            //tual e aktarıyorum
            Graphics tuval = this.CreateGraphics();
            Pen kalem = new Pen(renk, kalinlik);
            Brush firca = new SolidBrush(renk);

            if (dolumu == true)
                tuval.FillRectangle(firca, x, y, gen, yuk);
            else
                tuval.DrawRectangle(kalem, x, y, gen, yuk);
            tuval.Dispose();
        }

        void elips_ciz(int x, int y, int gen,int yuk,bool dolumu,int kalinlik,Color renk)
        {
            //fomun çizim olaylarını ve özelliklerini
            //tual e aktarıyorum
            Graphics tuval = this.CreateGraphics();
            Pen kalem = new Pen(renk, kalinlik);
            Brush firca = new SolidBrush(renk);

            if (dolumu == true)
                tuval.FillEllipse(firca, x, y, gen, yuk);
            else
                tuval.DrawEllipse(kalem, x, y, gen, yuk);
            tuval.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btRenk.BackColor = colorDialog1.Color;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            /*farenin x ve y koordinatları hafızata alınıyor
             (ilk basıldığı nokta)*/
            x_bas = e.X;
            y_bas = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x_bit, y_bit, gen, yuk;
            x_bit = e.X;
            y_bit = e.Y;

            gen = Math.Abs(x_bit - x_bas);
            yuk = Math.Abs(y_bit - y_bas);

            if (rbDikdörtgen.Checked == true)
                dortgen_ciz(x_bas, y_bas, gen, yuk, rbDolu.Checked,
                Convert.ToInt32(nuKalinlik.Value), btRenk.BackColor);
            else if(rbElips.Checked== true)
                elips_ciz(x_bas, y_bas, gen, yuk, rbDolu.Checked,
               Convert.ToInt32(nuKalinlik.Value), btRenk.BackColor);

        }
    }
}

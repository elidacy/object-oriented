
namespace çizim_uygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRenk = new System.Windows.Forms.Button();
            this.nuKalinlik = new System.Windows.Forms.NumericUpDown();
            this.rbElips = new System.Windows.Forms.RadioButton();
            this.rbDikdörtgen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rbDolu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuKalinlik)).BeginInit();
            this.SuspendLayout();
            // 
            // btRenk
            // 
            this.btRenk.Location = new System.Drawing.Point(32, 54);
            this.btRenk.Name = "btRenk";
            this.btRenk.Size = new System.Drawing.Size(94, 29);
            this.btRenk.TabIndex = 0;
            this.btRenk.Text = "Renk";
            this.btRenk.UseVisualStyleBackColor = true;
            this.btRenk.Click += new System.EventHandler(this.btRenk_Click);
            // 
            // nuKalinlik
            // 
            this.nuKalinlik.Location = new System.Drawing.Point(170, 54);
            this.nuKalinlik.Name = "nuKalinlik";
            this.nuKalinlik.Size = new System.Drawing.Size(150, 27);
            this.nuKalinlik.TabIndex = 2;
            // 
            // rbElips
            // 
            this.rbElips.AutoSize = true;
            this.rbElips.Location = new System.Drawing.Point(376, 53);
            this.rbElips.Name = "rbElips";
            this.rbElips.Size = new System.Drawing.Size(61, 24);
            this.rbElips.TabIndex = 3;
            this.rbElips.TabStop = true;
            this.rbElips.Text = "Elips";
            this.rbElips.UseVisualStyleBackColor = true;
            // 
            // rbDikdörtgen
            // 
            this.rbDikdörtgen.AutoSize = true;
            this.rbDikdörtgen.Location = new System.Drawing.Point(467, 53);
            this.rbDikdörtgen.Name = "rbDikdörtgen";
            this.rbDikdörtgen.Size = new System.Drawing.Size(105, 24);
            this.rbDikdörtgen.TabIndex = 4;
            this.rbDikdörtgen.TabStop = true;
            this.rbDikdörtgen.Text = "Dikdörtgen";
            this.rbDikdörtgen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Çizgi Kalınlığı";
            // 
            // rbDolu
            // 
            this.rbDolu.AutoSize = true;
            this.rbDolu.Location = new System.Drawing.Point(604, 55);
            this.rbDolu.Name = "rbDolu";
            this.rbDolu.Size = new System.Drawing.Size(63, 24);
            this.rbDolu.TabIndex = 6;
            this.rbDolu.Text = "Dolu";
            this.rbDolu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbDolu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDikdörtgen);
            this.Controls.Add(this.rbElips);
            this.Controls.Add(this.nuKalinlik);
            this.Controls.Add(this.btRenk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.nuKalinlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRenk;
        private System.Windows.Forms.NumericUpDown nuKalinlik;
        private System.Windows.Forms.RadioButton rbElips;
        private System.Windows.Forms.RadioButton rbDikdörtgen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox rbDolu;
    }
}


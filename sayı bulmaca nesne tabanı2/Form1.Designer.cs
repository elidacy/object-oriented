
namespace sayı_bulmaca_nesne_tabanı2
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
            this.lahedefsayi = new System.Windows.Forms.Label();
            this.tbsayi1 = new System.Windows.Forms.TextBox();
            this.lbislem = new System.Windows.Forms.ListBox();
            this.tbsayi2 = new System.Windows.Forms.TextBox();
            this.btsonuc = new System.Windows.Forms.Button();
            this.lbrakamlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sayi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lahedefsayi
            // 
            this.lahedefsayi.AutoSize = true;
            this.lahedefsayi.Location = new System.Drawing.Point(184, 98);
            this.lahedefsayi.Name = "lahedefsayi";
            this.lahedefsayi.Size = new System.Drawing.Size(33, 20);
            this.lahedefsayi.TabIndex = 0;
            this.lahedefsayi.Text = "000";
            // 
            // tbsayi1
            // 
            this.tbsayi1.Location = new System.Drawing.Point(28, 183);
            this.tbsayi1.Name = "tbsayi1";
            this.tbsayi1.ReadOnly = true;
            this.tbsayi1.Size = new System.Drawing.Size(125, 27);
            this.tbsayi1.TabIndex = 1;
            // 
            // lbislem
            // 
            this.lbislem.FormattingEnabled = true;
            this.lbislem.ItemHeight = 20;
            this.lbislem.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.lbislem.Location = new System.Drawing.Point(173, 151);
            this.lbislem.Name = "lbislem";
            this.lbislem.Size = new System.Drawing.Size(55, 84);
            this.lbislem.TabIndex = 2;
            // 
            // tbsayi2
            // 
            this.tbsayi2.Location = new System.Drawing.Point(252, 183);
            this.tbsayi2.Name = "tbsayi2";
            this.tbsayi2.ReadOnly = true;
            this.tbsayi2.Size = new System.Drawing.Size(125, 27);
            this.tbsayi2.TabIndex = 3;
            // 
            // btsonuc
            // 
            this.btsonuc.Location = new System.Drawing.Point(409, 183);
            this.btsonuc.Name = "btsonuc";
            this.btsonuc.Size = new System.Drawing.Size(60, 29);
            this.btsonuc.TabIndex = 4;
            this.btsonuc.Text = "=";
            this.btsonuc.UseVisualStyleBackColor = true;
            this.btsonuc.Click += new System.EventHandler(this.btsonuc_Click);
            // 
            // lbrakamlar
            // 
            this.lbrakamlar.FormattingEnabled = true;
            this.lbrakamlar.ItemHeight = 20;
            this.lbrakamlar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lbrakamlar.Location = new System.Drawing.Point(491, 51);
            this.lbrakamlar.Name = "lbrakamlar";
            this.lbrakamlar.Size = new System.Drawing.Size(37, 184);
            this.lbrakamlar.TabIndex = 5;
            this.lbrakamlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbrakamlar_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "1.sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "2.sayı";
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(152, 40);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(97, 29);
            this.sayi.TabIndex = 8;
            this.sayi.Text = "sayı gelsin";
            this.sayi.UseVisualStyleBackColor = true;
            this.sayi.Click += new System.EventHandler(this.sayi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbrakamlar);
            this.Controls.Add(this.btsonuc);
            this.Controls.Add(this.tbsayi2);
            this.Controls.Add(this.lbislem);
            this.Controls.Add(this.tbsayi1);
            this.Controls.Add(this.lahedefsayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lahedefsayi;
        private System.Windows.Forms.TextBox tbsayi1;
        private System.Windows.Forms.ListBox lbislem;
        private System.Windows.Forms.TextBox tbsayi2;
        private System.Windows.Forms.Button btsonuc;
        private System.Windows.Forms.ListBox lbrakamlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sayi;
    }
}


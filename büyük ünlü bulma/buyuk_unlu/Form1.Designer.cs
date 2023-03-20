
namespace buyuk_unlu
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
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.btBul = new System.Windows.Forms.Button();
            this.lbUyan = new System.Windows.Forms.ListBox();
            this.lbUymayan = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbMetin
            // 
            this.rtbMetin.Location = new System.Drawing.Point(54, 65);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(257, 290);
            this.rtbMetin.TabIndex = 0;
            this.rtbMetin.Text = "";
            // 
            // btBul
            // 
            this.btBul.Location = new System.Drawing.Point(317, 191);
            this.btBul.Name = "btBul";
            this.btBul.Size = new System.Drawing.Size(94, 29);
            this.btBul.TabIndex = 1;
            this.btBul.Text = "Bul >>>";
            this.btBul.UseVisualStyleBackColor = true;
            this.btBul.Click += new System.EventHandler(this.btBul_Click);
            // 
            // lbUyan
            // 
            this.lbUyan.FormattingEnabled = true;
            this.lbUyan.ItemHeight = 20;
            this.lbUyan.Location = new System.Drawing.Point(429, 65);
            this.lbUyan.Name = "lbUyan";
            this.lbUyan.Size = new System.Drawing.Size(150, 284);
            this.lbUyan.TabIndex = 2;
            // 
            // lbUymayan
            // 
            this.lbUymayan.FormattingEnabled = true;
            this.lbUymayan.ItemHeight = 20;
            this.lbUymayan.Location = new System.Drawing.Point(620, 65);
            this.lbUymayan.Name = "lbUymayan";
            this.lbUymayan.Size = new System.Drawing.Size(150, 284);
            this.lbUymayan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uyanlar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uymayanlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUymayan);
            this.Controls.Add(this.lbUyan);
            this.Controls.Add(this.btBul);
            this.Controls.Add(this.rtbMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.Button btBul;
        private System.Windows.Forms.ListBox lbUyan;
        private System.Windows.Forms.ListBox lbUymayan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


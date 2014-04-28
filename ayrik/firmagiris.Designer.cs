namespace ayrik
{
    partial class firmagiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFirmaYukle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUretici = new System.Windows.Forms.TextBox();
            this.txtTuketici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFirmaYukle
            // 
            this.btnFirmaYukle.Location = new System.Drawing.Point(269, 54);
            this.btnFirmaYukle.Name = "btnFirmaYukle";
            this.btnFirmaYukle.Size = new System.Drawing.Size(75, 23);
            this.btnFirmaYukle.TabIndex = 0;
            this.btnFirmaYukle.Text = "Firma Giriş";
            this.btnFirmaYukle.UseVisualStyleBackColor = true;
            this.btnFirmaYukle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üretici Firma Sayisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tüketici Firma Sayisi";
            // 
            // txtUretici
            // 
            this.txtUretici.Location = new System.Drawing.Point(67, 40);
            this.txtUretici.Name = "txtUretici";
            this.txtUretici.Size = new System.Drawing.Size(100, 20);
            this.txtUretici.TabIndex = 3;
            // 
            // txtTuketici
            // 
            this.txtTuketici.Location = new System.Drawing.Point(67, 93);
            this.txtTuketici.Name = "txtTuketici";
            this.txtTuketici.Size = new System.Drawing.Size(100, 20);
            this.txtTuketici.TabIndex = 4;
            // 
            // firmagiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(414, 285);
            this.Controls.Add(this.txtTuketici);
            this.Controls.Add(this.txtUretici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFirmaYukle);
            this.Name = "firmagiris";
            this.Text = "firmagiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.btnfirmagiris_FormClosed);
            this.Load += new System.EventHandler(this.btnfirmagiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmaYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUretici;
        private System.Windows.Forms.TextBox txtTuketici;
    }
}
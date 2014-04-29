namespace ayrik
{
    partial class Form1
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
            this.btnFirmTanımla = new System.Windows.Forms.Button();
            this.btnKusulGir = new System.Windows.Forms.Button();
            this.txtCarpan = new System.Windows.Forms.TextBox();
            this.lblCarpan = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblCarpan2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFirmTanımla
            // 
            this.btnFirmTanımla.Location = new System.Drawing.Point(58, 44);
            this.btnFirmTanımla.Name = "btnFirmTanımla";
            this.btnFirmTanımla.Size = new System.Drawing.Size(95, 72);
            this.btnFirmTanımla.TabIndex = 0;
            this.btnFirmTanımla.Text = "Firma Tanımla";
            this.btnFirmTanımla.UseVisualStyleBackColor = true;
            this.btnFirmTanımla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKusulGir
            // 
            this.btnKusulGir.Enabled = false;
            this.btnKusulGir.Location = new System.Drawing.Point(184, 44);
            this.btnKusulGir.Name = "btnKusulGir";
            this.btnKusulGir.Size = new System.Drawing.Size(95, 72);
            this.btnKusulGir.TabIndex = 1;
            this.btnKusulGir.Text = "Koşul Gir";
            this.btnKusulGir.UseVisualStyleBackColor = true;
            this.btnKusulGir.Click += new System.EventHandler(this.btnKusulGir_Click);
            // 
            // txtCarpan
            // 
            this.txtCarpan.Enabled = false;
            this.txtCarpan.Location = new System.Drawing.Point(325, 87);
            this.txtCarpan.Name = "txtCarpan";
            this.txtCarpan.Size = new System.Drawing.Size(100, 20);
            this.txtCarpan.TabIndex = 2;
            // 
            // lblCarpan
            // 
            this.lblCarpan.AutoSize = true;
            this.lblCarpan.Enabled = false;
            this.lblCarpan.Location = new System.Drawing.Point(322, 44);
            this.lblCarpan.Name = "lblCarpan";
            this.lblCarpan.Size = new System.Drawing.Size(129, 13);
            this.lblCarpan.TabIndex = 3;
            this.lblCarpan.Text = "Koşul çarpanı varsa giriniz";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Enabled = false;
            this.btnHesapla.Location = new System.Drawing.Point(503, 44);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(95, 72);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblCarpan2
            // 
            this.lblCarpan2.AutoSize = true;
            this.lblCarpan2.Enabled = false;
            this.lblCarpan2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCarpan2.Location = new System.Drawing.Point(326, 61);
            this.lblCarpan2.Name = "lblCarpan2";
            this.lblCarpan2.Size = new System.Drawing.Size(119, 13);
            this.lblCarpan2.TabIndex = 5;
            this.lblCarpan2.Text = "( 1 den büyük tam sayı )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 190);
            this.Controls.Add(this.lblCarpan2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblCarpan);
            this.Controls.Add(this.txtCarpan);
            this.Controls.Add(this.btnKusulGir);
            this.Controls.Add(this.btnFirmTanımla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmTanımla;
        private System.Windows.Forms.Button btnKusulGir;
        private System.Windows.Forms.TextBox txtCarpan;
        private System.Windows.Forms.Label lblCarpan;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblCarpan2;


    }
}


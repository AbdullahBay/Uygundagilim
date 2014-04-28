using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace ayrik
{
    public partial class Sonuc : Form
    {
        public hesaplama hesaplama;
        public bool formKontrol=false;
        Label[,] lblSonuclar;
        Label[] lblAd;

        public Sonuc(ref hesaplama hesaplama)
        {
            this.hesaplama = hesaplama;
            InitializeComponent();
        }

        private void Sonuc_Load(object sender, EventArgs e)
        {
            formKontrol = true;
            int satir = hesaplama.tuketici;
            int sutun = hesaplama.uretici;

            lblSonuclar = new Label[satir, sutun+1];
            int topArtis = 30, leftArtis = 120;
            lblAd = new Label[satir + sutun+1];

            #region label ayarı
            for (int i = 0; i < sutun; i++)
            {
                lblAd[satir + i] = new Label();
                lblAd[satir + i].Left = 120 + i * leftArtis;
                lblAd[satir + i].Top = 15;
                Controls.Add(lblAd[satir + i]);
                lblAd[satir + i].Text = hesaplama.Ad[i + satir];
            }
            lblAd[satir + sutun] = new Label();
            lblAd[satir + sutun].Left = 120 + sutun * leftArtis;
            lblAd[satir + sutun].Top = 15;
            Controls.Add(lblAd[satir + sutun]);
            lblAd[satir + sutun].Text = "Ara toplam";
            #endregion

            for (int i = 0; i < satir; i++)
            {
                lblAd[i] = new Label();
                lblAd[i].Left = 20;
                lblAd[i].Top = 15 + (i + 1) * topArtis;
                lblAd[i].AutoSize = true;
                Controls.Add(lblAd[i]);
                lblAd[i].Text = hesaplama.Ad[i];

                for (int j = 0; j < sutun+1; j++)
                {
                    lblSonuclar[i, j] = new Label();
                    lblSonuclar[i, j].Text = hesaplama.SonucMatrisi[i, j].ToString();
                    lblSonuclar[i, j].Left = 120 + j * leftArtis;
                    lblSonuclar[i, j].Top = 40 + i * topArtis;
                    Controls.Add(lblSonuclar[i, j]);

                }
            }
            

            Label lblToplam = new Label();
            lblToplam.Text = hesaplama.toplama.ToString();
            lblToplam.Left= 120 + sutun * leftArtis;
            lblToplam.Top = 40 + (satir ) * topArtis;
            Controls.Add(lblToplam);
            
            
            Button btnKapat = new Button();
            btnKapat.Text = "Kapat";
            btnKapat.Left =120+sutun*leftArtis ;
            btnKapat.Top = 40 + (satir + 1) * topArtis;
            Controls.Add(btnKapat);
            btnKapat.Click += btnOnay_Click;
            this.SuspendLayout();
        }
       

        void btnOnay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

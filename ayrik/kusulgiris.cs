using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace ayrik
{
    public partial class kusulgiris : Form
    {

        public kusulgiris(ref hesaplama hesaplama)
        {
            this.hesaplama = hesaplama;
            InitializeComponent();
        }
        TextBox[,] txtKosullar;
        Label[] lblAd;
        public hesaplama hesaplama;
        public bool formKontrol;

        private void kusulgiris_Load(object sender, EventArgs e)
        {
            formKontrol = false;
            int satir = hesaplama.tuketici; 
            int sutun = hesaplama.uretici;

            txtKosullar = new TextBox[satir, sutun];
            int topArtis = 30, leftArtis = 120;
            lblAd = new Label[satir + sutun];

            #region label ayarı
            for (int i = 0; i < sutun; i++)
            {
                lblAd[satir + i] = new Label();
                lblAd[satir + i].Left = 120 + i * leftArtis;
                lblAd[satir + i].Top = 15;
                Controls.Add(lblAd[satir + i]);
                lblAd[satir + i].Text = hesaplama.Ad[i+satir];
            }
            #endregion
                
                for (int i = 0; i < satir; i++)
            {
                lblAd[i] = new Label();
                lblAd[i].Left = 20;
                lblAd[i].Top = 15 + (i + 1) * topArtis;
                lblAd[i].AutoSize = true;
                Controls.Add(lblAd[i]);
                lblAd[i].Text = hesaplama.Ad[i];

                for (int j = 0; j < sutun; j++)
                {
                    txtKosullar[i, j] = new TextBox();
                    txtKosullar[i, j].Left = 120 + j * leftArtis;
                    txtKosullar[i, j].Top = 40 + i * topArtis;
                    Controls.Add(txtKosullar[i, j]);

                }
            }
            Button btnOnay = new Button();
            btnOnay.Text = "Onay";
            btnOnay.Left = 120 + sutun * leftArtis;
            btnOnay.Top = 42 + satir * topArtis;
            Controls.Add(btnOnay);
            btnOnay.Click += btnOnay_Click;
            this.SuspendLayout();
        }

        void btnOnay_Click(object sender, EventArgs e)
        {
            int [,] dizi=new int [hesaplama.tuketici,hesaplama.uretici];
            for (int i = 0; i < hesaplama.tuketici; i++)
			{
			    for (int j = 0; j < hesaplama.uretici; j++)
			    {
			        dizi[i,j]=Convert.ToInt32(txtKosullar[i, j].Text);
			    }
			}
            hesaplama.kosulVeri(dizi);
            formKontrol = true;
            this.Close();
        }
       
    }
}

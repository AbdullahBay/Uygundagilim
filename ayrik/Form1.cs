using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace ayrik
{
    public partial class Form1 : Form
    {
        firmagiris formGiris;
        kusulgiris formKosul;
        hesaplama hesaplama;
        Sonuc formSonuc;

        public Form1()
        {
            InitializeComponent();
            hesaplama = new hesaplama();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formGiris = new firmagiris(ref hesaplama);
            formGiris.ShowDialog();

            if (formGiris.Formkontrol == true)
            {
                btnKusulGir.Enabled = true;
            }
            else
            {
                btnKusulGir.Enabled =   lblCarpan.Enabled = lblCarpan2.Enabled=   txtCarpan.Enabled =   btnHesapla.Enabled = false;
            }
        }

        

        private void btnKusulGir_Click(object sender, EventArgs e)
        {
            formKosul = new kusulgiris(ref hesaplama);
            //formKosul.hesapgonder(hesap);
            formKosul.ShowDialog();
            if (formKosul.formKontrol == true)
            {
                lblCarpan.Enabled = true;
                lblCarpan2.Enabled = true;
                txtCarpan.Enabled = true;
                btnHesapla.Enabled = true;
            } 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            if (txtCarpan.Text!="")
            {
                if (Convert.ToInt32(txtCarpan.Text)>1)
                {
                    hesaplama.CarpanlaCarp(Convert.ToInt32(txtCarpan.Text));
                }
                
            }
            hesaplama.hesap();
            formSonuc = new Sonuc(ref hesaplama);
            formSonuc.ShowDialog();
        }

        private void CarpanlaCarp()
        {
            throw new NotImplementedException();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace ayrik
{
    public partial class firmagiris : Form
    {
        public hesaplama hesaplama;
        
        public firmagiris(ref hesaplama hesap)
        {
            hesaplama = hesap;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtUretici.Text!="" && txtTuketici.Text!="")
            {
                label1.Hide();
                label2.Hide();
                txtTuketici.Hide();
                txtUretici.Hide();
                btnFirmaYukle.Hide();
                hesaplama.uretici = Convert.ToInt32(txtUretici.Text); 
                hesaplama.tuketici = Convert.ToInt32(txtTuketici.Text);
                firmaYukle();
            }
            else
            {
                MessageBox.Show("Boş Alanları doldurunuz.");
            }
            
        }


        public TextBox[,] textBox;
        ComboBox[] cmbUrTu;
        int satir;

        public void firmaYukle()
        {
            #region labeller
            // 
            // label1
            // 
            Label label1 = new Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();

            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 13);
            label1.TabIndex = 0;
            label1.Text = "Firma Adi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(158, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 13);
            label2.TabIndex = 3;
            label2.Text = "Üretim/Tüketim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(310, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 13);
            label3.TabIndex = 4;
            label3.Text = "Adet";
            // 
            // Form1
            // 
            ClientSize = new System.Drawing.Size(757, 261);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            #endregion

            int uretici = hesaplama.uretici;
            int tuketici = hesaplama.tuketici;
            satir = uretici+tuketici;
            textBox = new TextBox[satir, 2];
            cmbUrTu = new ComboBox[satir];

            int topSpace = 30, i;
            for ( i = 0; i < satir; i++)
            {
                textBox[i, 0] = new TextBox();
                cmbUrTu[i] = new ComboBox();
                textBox[i, 1] = new TextBox();
                
                // 
                // textBox[i,0]
                // 
                textBox[i, 0].Location = new System.Drawing.Point(31, 42 + i * topSpace);
                textBox[i, 0].Name = "textBox[0]";
                textBox[i, 0].Size = new System.Drawing.Size(100, 20);
                textBox[i, 0].TabIndex = 1;
                // 
                // cmbUrTu[i]
                // 
                cmbUrTu[i].FormattingEnabled = true;
                cmbUrTu[i].Items.AddRange(new object[] {
                "Üretim",
                "Tüketim"});
                cmbUrTu[i].Enabled = false;
                cmbUrTu[i].Location = new System.Drawing.Point(158, 42 + i * topSpace);
                cmbUrTu[i].Name = "cmbUrTu[i]";
                cmbUrTu[i].Size = new System.Drawing.Size(121, 21);
                cmbUrTu[i].TabIndex = 2;
                cmbUrTu[i].SelectedIndex =( i >= tuketici) ? 0:1;
                
                // 
                // textBox[i,1]
                // 
                textBox[i, 1].Location = new System.Drawing.Point(313, 42 + i * topSpace);
                textBox[i, 1].Name = "textBox[i,1]";
                textBox[i, 1].Size = new System.Drawing.Size(100, 20);
                textBox[i, 1].TabIndex = 5;
                // 
                // Form1
                // 
                AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                ClientSize = new System.Drawing.Size(492, 340);
                Controls.Add(textBox[i, 1]);

                Controls.Add(cmbUrTu[i]);
                Controls.Add(textBox[i, 0]);
                Controls.Add(textBox[i, 1]);
            }
            Button btnOnay = new Button();
            btnOnay.Text = "Onay";
            btnOnay.Left=313 ;
            btnOnay.Top=42 + i * topSpace;
            Controls.Add(btnOnay);
            btnOnay.Click += btnOnay_Click;
        }
        /*önce tüketici sonra üretici depolanıyor */
        private String[] Ad;
        private int[,] IdAdetTU;
        public bool Formkontrol = false;
        void btnOnay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < satir; i++)
            {
                if (textBox[i, 0].Text == "")
                {
                    if (cmbUrTu[i].SelectedIndex==0)
	                {
                        textBox[i, 0].Text = "Uretici " + Convert.ToString(i);
	                }
                    else
                    {
                        textBox[i, 0].Text = "Tüketici " + Convert.ToString(hesaplama.tuketici-i);
                    }
                    
                }
                if (textBox[i, 1].Text == "")
                {
                    MessageBox.Show("Bos Alan Bırakmayınız");
                    return;
                }
                if (textBox[i, 0].Text == "" )
                {
                    MessageBox.Show("Bos Alan Bırakmayınız");
                    return;
                }
            }
            
            Ad = new String[satir];
            IdAdetTU =new int [satir,3];
            

            for (int i = 0; i < satir; i++)
            {
                /*IdAdetTU[i, 0] = new int();
                IdAdetTU[i, 1] = new int();
                IdAdetTU[i, 2] = new int();*/
                Ad[i] = textBox[i, 0].Text;
                Ad[i] = textBox[i, 0].Text;
                IdAdetTU[i, 0] = i;
                IdAdetTU[i, 1] = Convert.ToInt32(textBox[i,1].Text);
                IdAdetTU[i, 2] = cmbUrTu[i].SelectedIndex;
            }
            
            hesaplama.firmaGirisVeri(IdAdetTU,Ad);
            Formkontrol = true;
            this.Close();
        }
        // sade say girişi
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // sadece harf girişi
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }
        private void btnfirmagiris_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnfirmagiris_Load(object sender, EventArgs e)
        {

        }
    }
}

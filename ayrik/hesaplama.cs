using System;
using System.Collections.Generic;
using System.Text;


namespace ayrik
{
    public class hesaplama
    {
        /*önce tüketici sonra üretici depolanıyor */
        public String[] Ad;
        //uretim tuketim durumunu göstermek için bir enum;
        private enum U_TDurumu { uretim, tuketim, hepsi ,hicBiri};
        //[i;indis, değer,uretim/tuketim]
        public int[,] Matris;
        public int DiziUzunlugu;
        public int[,] hesaplamaMatrisi;
        public int[,] SonucMatrisi;
        public String durumMesaji="";
        public int uretici;
        public int tuketici;
        public int toplama=0;
        public void hesap()
        {
            SonucMatrisi=new int[tuketici,uretici+1];

            int[] Indis;
            int I, J;
            U_TDurumu durum;

            while (true)
            {
                durum = bittiMi();
                if (durum == U_TDurumu.hicBiri)
                {
                    durumMesaji = "Üretimle tüketim eşit sayıda olup tüm malzeme dağıtılmıştır";
                    break;
                }
                else if (durum == U_TDurumu.tuketim)
                {
                    durumMesaji = "Yeterli sayıda üretim yok.";
                    break;
                }
                
                else if (durum == U_TDurumu.uretim)
                {
                    durumMesaji = "İhtiyaç fazlası üretim yapılıyor.";
                    break;
                }
                else if (durum == U_TDurumu.hepsi)
                {

                    Indis = enkucukIndis();
                    I = Indis[0]; J = Indis[1];
                    //uretim tuketimden daha büyükse
                    //-1 i sildim
                    if (Matris[tuketici + J, 1] > Matris[I, 1])
                    {
                        SonucMatrisi[I, J] += Matris[I, 1];
                        Matris[tuketici + J, 1] -= Matris[I, 1];
                        Matris[I, 1] = 0;
                        hesaplamaMatrisi[I, uretici] = 0;
                    }
                    else if (Matris[tuketici + J, 1] == Matris[I, 1])
                    {
                        SonucMatrisi[I, J] += Matris[I, 1];
                        Matris[I, 1] = 0;
                        Matris[tuketici + J, 1] = 0;
                        hesaplamaMatrisi[I, uretici] = 0;
                        hesaplamaMatrisi[tuketici, J] = 0;
                    }
                    //  tuketim uretimden büyükse
                    else
                    {
                        SonucMatrisi[I, J] += Matris[tuketici + J, 1];
                        Matris[I, 1] -= Matris[tuketici + J, 1];
                        Matris[tuketici + J, 1] = 0;
                        hesaplamaMatrisi[tuketici, J] = 0;

                        //SonucMatrisi[I, J] = Matris[I, 1];
                        // Matris[I, uretici] = 0;
                    }
                }
                for (int i = 0; i < tuketici; i++)
                {
                    for (int j = 0; j < uretici; j++)
                    {
                        SonucMatrisi[i, uretici] += SonucMatrisi[i, j] * hesaplamaMatrisi[i, j];
                    }

                }
                
            }
            toplam();
        }
        private void toplam()
        {
            for (int i = 0; i < tuketici; i++)
            {
                toplama += SonucMatrisi[i, uretici];
            }
        }
        // hala deeğerlendirilmesi gerekn durumu döndürür
        private U_TDurumu bittiMi()
        {
            // hiç kamamış olma durumu;
            U_TDurumu durum = U_TDurumu.hicBiri;

            //tuketimden kalmışsa if e girer
            for (int i = 0; i < uretici; i++)
            {
                if(hesaplamaMatrisi[tuketici, i] == 1){
                    durum=U_TDurumu.tuketim;
                }
                       
            }
            //uretimden kamışsa if e girer.
            // 
            for (int i = 0; i < tuketici; i++)
            {
                if (hesaplamaMatrisi[i, uretici] == 1)
                {
                    if (durum==U_TDurumu.tuketim)
                    {
                        durum = U_TDurumu.hepsi;
                    }
                    else
                    {
                        durum = U_TDurumu.uretim;
                    }
                    break;
                } 
            }
            //son durum döndürülür
            return durum;

        }

        public void kosulVeri(int[,] kosulDizisi)
        {
            hesaplamaMatrisi = new int[tuketici + 1, uretici + 1];

            for (int i = 0; i < tuketici; i++)
            {
                hesaplamaMatrisi[i, uretici]=1;
                for (int j = 0; j < uretici; j++)
                {
                    hesaplamaMatrisi[i, j] = kosulDizisi[i,j];
                }
            }
            for (int i = 0; i < uretici; i++)
            {
                hesaplamaMatrisi[tuketici, i]=1;
            }
            
        }

        public void firmaGirisVeri(int[,] IdAdetTU,String[] Ad)
        {
            this.DiziUzunlugu = uretici+tuketici;
            Matris = new int[DiziUzunlugu, 3];
            this.Ad = Ad;
            for (int i = 0; i < DiziUzunlugu; i++)
            {
                Matris[i, 0] = IdAdetTU[i, 0];
                Matris[i, 1] = IdAdetTU[i, 1];
                Matris[i, 2] = IdAdetTU[i, 2];
            }
        }

        public int[] enkucukIndis()
        {
            int indisI = 0, indisJ = 0;
            int[,] Indis = new int[tuketici, 2];
            int karsilastirma = 0;
            int ilk = 0, ilksatir = 0; ;


            for (int i = 0; i < tuketici; i++)
            {
                ilk = 0;
                if (hesaplamaMatrisi[i, uretici] == 0)
                {
                    Indis[i, 1] = -1;
                    Indis[i, 0] = -1;
                    continue;
                }

                for (int j = 0; j < uretici; j++)
                {
                    if (hesaplamaMatrisi[tuketici, j] == 0)
                    {
                        continue;
                    }
                    else if (ilksatir == 0)
                    {
                        ilksatir++;
                        indisI = i;
                        indisJ = j;
                    }
                    if (ilk == 0)
                    {
                        ilk++;
                        karsilastirma = hesaplamaMatrisi[i, j];
                        Indis[i, 0] = i;
                        Indis[i, 1] = j;
                    }
                    else
                    {
                        if (hesaplamaMatrisi[i, j] < karsilastirma)
                        {
                            Indis[i, 0] = i;
                            Indis[i, 1] = j;

                        }
                    }
                }
                //if (Indis[i, 0] != -1) ye gerek yok zaten ij ise buraya gelemez
                if (hesaplamaMatrisi[Indis[i, 0], Indis[i, 1]] < hesaplamaMatrisi[indisI, indisJ])
                {
                    indisI = Indis[i, 0];
                    indisJ = Indis[i, 1];
                }

            }
            return new int[2] { indisI, indisJ };
        }

        public void CarpanlaCarp(int carpan)
        {
            for (int i = 0; i < tuketici; i++)
            {
                for (int j = 0; j < uretici; j++)
                {
                    hesaplamaMatrisi[i, j] *= carpan;
                }
            }
        }
    }
}

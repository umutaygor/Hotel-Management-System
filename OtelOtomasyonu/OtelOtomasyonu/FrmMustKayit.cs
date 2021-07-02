using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public partial class FrmMustKayit : Form
    {
        public FrmMustKayit()
        {
            InitializeComponent();
        }
        
        SqlBaglanti bgl = new SqlBaglanti();
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMustKayit_Load(object sender, EventArgs e)
        {
            //Şehirleri Listeleme  
            SqlCommand komut = new SqlCommand("Select SehirAd From Sehir", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                CmbSehir.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();


            //Boş odaları Listeleme 
            SqlCommand komut2 = new SqlCommand("select OdaNo from Odalar where OdaAktif=0", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
            



        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                int number = Convert.ToInt32(CmbOdaNo.Text);
                int sure = Convert.ToInt32(TxtOdaSure.Text);

                                                                    //Yeni Müşteri Kaydetme

                if (TxtKisiSayisi.Text == "1" && number >= 100)
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Musteri (MustAd,MustSoyad,MustTC,MustTel,MustDogum,MustSehir,MustMail,MustOdaNo,MustAdres,MustSure) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@p1", TxtMustAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtMustSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", MskMustTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", MskMustDogum.Text);
                    komutkaydet.Parameters.AddWithValue("@p6", CmbSehir.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                    komutkaydet.Parameters.AddWithValue("@p9", RchAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p10", TxtOdaSure.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Başarılı");

                    SqlCommand komut = new SqlCommand("select Mustid from Musteri", bgl.baglanti());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        label10.Text = oku[0].ToString();
                    }

                    SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+" + TxtKisiSayisi.Text + " where OdaNo=@oda1", bgl.baglanti());
                    komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
                    komutoda.ExecuteNonQuery();
                    
                    bgl.baglanti().Close();
                }
                else if(TxtKisiSayisi.Text == "2" && number >= 200)
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Musteri (MustAd,MustSoyad,MustTC,MustTel,MustDogum,MustSehir,MustMail,MustOdaNo,MustAdres,MustSure) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@p1", TxtMustAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtMustSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", MskMustTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", MskMustDogum.Text);
                    komutkaydet.Parameters.AddWithValue("@p6", CmbSehir.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                    komutkaydet.Parameters.AddWithValue("@p9", RchAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p10", TxtOdaSure.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Başarılı");

                    SqlCommand komut = new SqlCommand("select Mustid from Musteri", bgl.baglanti());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        label10.Text = oku[0].ToString();
                    }

                    SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+" + TxtKisiSayisi.Text + " where OdaNo=@oda1", bgl.baglanti());
                    komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
                    komutoda.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
                else if(TxtKisiSayisi.Text == "3" && number >= 300)
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Musteri (MustAd,MustSoyad,MustTC,MustTel,MustDogum,MustSehir,MustMail,MustOdaNo,MustAdres,MustSure) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@p1", TxtMustAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtMustSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", MskMustTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", MskMustDogum.Text);
                    komutkaydet.Parameters.AddWithValue("@p6", CmbSehir.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                    komutkaydet.Parameters.AddWithValue("@p9", RchAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p10", TxtOdaSure.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Başarılı");

                    SqlCommand komut = new SqlCommand("select Mustid from Musteri", bgl.baglanti());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        label10.Text = oku[0].ToString();
                    }

                    SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+" + TxtKisiSayisi.Text + " where OdaNo=@oda1", bgl.baglanti());
                    komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
                    komutoda.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
                else if(TxtKisiSayisi.Text == "4" && number >= 400)
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Musteri (MustAd,MustSoyad,MustTC,MustTel,MustDogum,MustSehir,MustMail,MustOdaNo,MustAdres,MustSure) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@p1", TxtMustAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", TxtMustSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", MskMustTelefon.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", MskMustDogum.Text);
                    komutkaydet.Parameters.AddWithValue("@p6", CmbSehir.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", TxtMail.Text);
                    komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                    komutkaydet.Parameters.AddWithValue("@p9", RchAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p10", TxtOdaSure.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt Başarılı");

                    SqlCommand komut = new SqlCommand("select Mustid from Musteri", bgl.baglanti());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        label10.Text = oku[0].ToString();
                    }

                    SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+" + TxtKisiSayisi.Text + " where OdaNo=@oda1", bgl.baglanti());
                    komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
                    komutoda.ExecuteNonQuery();

                    bgl.baglanti().Close();
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Oda Kapasitesi " + TxtKisiSayisi.Text + " Kişiye Yetecek Kadar Büyük Değil! \n 1 Kişilik Odalar 100-110 Arası \n 2 Kişilik Odalar 200-210 Arası \n 3 Kişilik Odalar 300-310 Arası \n 4 Kişilik Odalar 400-410 Arasıdır.");
                }


                // Müşteri Borç Alanı Oluşturma
                

                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar(Mustid,MustAd,MustSoyad,MustKalanBorc) values(@b1,@b2,@b3,@b4)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label10.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtMustAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtMustSoyad.Text);
                
                                                                    // 1 Kişilik Oda Borç Oluşturma


                if (TxtKisiSayisi.Text== "1" && number>=100 && number <= 110)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure*150);
                }
                if (TxtKisiSayisi.Text == "1" && number >= 200 && number <= 210)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure * 200);
                }
                if (TxtKisiSayisi.Text == "1" && number >= 300 && number <= 310)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure * 250);
                }
                if (TxtKisiSayisi.Text == "1" && number >= 400 && number <= 410)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure * 300);
                }
                                                    
                                                                    // 2 Kişilik Oda Borç Oluşturma
                                            

                if (TxtKisiSayisi.Text == "2" && number >=200 && number <= 210) {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure*200);
                }
                if (TxtKisiSayisi.Text == "2" && number >= 300 && number <= 310)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure * 250);
                }
                if (TxtKisiSayisi.Text == "2" && number >= 400 && number <= 410)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure * 300);
                }


                                                                       //3 Kişilik Oda Borç Oluşturma



                if (TxtKisiSayisi.Text == "3" && number >= 300 && number <= 310)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure*250);
                }
                if (TxtKisiSayisi.Text == "3" && number >= 400 && number <= 410)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure * 300);
                }

                                                                       //4 Kişilik Oda Borç Oluşturma


                if (TxtKisiSayisi.Text == "4" && number >= 400 && number <= 410)
                {
                    komutkaydet2.Parameters.AddWithValue("@b4", sure*300);
                }

                
                
                ((FrmAnaForm)Application.OpenForms["FrmAnaForm"]).dgdoldur();

                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

               
            }
            catch (Exception)
            {
                
                
                MessageBox.Show("Hata!");
                
            }
            
           
            //Odalarin  Kontenjan Durumlarini Belirleme
            /*SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+"+TxtKisiSayisi.Text+" where OdaNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close(); */

        }





        private void TxtOdaFiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtKisiSayisi_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

//Data Source=DESKTOP-DLGL86M;Initial Catalog=OtelOtomasyonu;Integrated Security=True
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
    public partial class FrmMustDuzenle : Form
    {
        public FrmMustDuzenle()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,tc,tel,dgm_trh,sehir,mail,odano,sure,adres;

        private void Button1_Click(object sender, EventArgs e)
        {

            //Müşteri Silme
            
            SqlCommand komutsil = new SqlCommand("delete from Musteri where Mustid=@k1", bgl.baglanti());           
            komutsil.Parameters.AddWithValue("@k1", TxtMustId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");

            //Oda Kontenjanı Arttırma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=0 where OdaNo=@oda ", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        SqlBaglanti bgl = new SqlBaglanti();

        //Müşteri Bilgi Güncelleme
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Musteri set MustAd=@p2,MustSoyad=@p3,MustTC=@p4,MustTel=@p5,MustDogum=@p6,MustSehir=@p7,MustMail=@p8,MustOdaNo=@p9,MustSure=@p10,MustAdres=@p11 where Mustid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtMustId.Text);
            komut.Parameters.AddWithValue("@p2", TxtMustAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtMustSoyad.Text);
            komut.Parameters.AddWithValue("@p4", MskTC.Text);
            komut.Parameters.AddWithValue("@p5", MskMustTelefon.Text);
            komut.Parameters.AddWithValue("@p6", MskMustDogum.Text);
            komut.Parameters.AddWithValue("@p7", CmbSehir.Text);
            komut.Parameters.AddWithValue("@p8", TxtMail.Text);
            komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
            komut.Parameters.AddWithValue("@p10", TxtOdaSure.Text);
            komut.Parameters.AddWithValue("@p11", RchAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
           MessageBox.Show("Güncelleme Başarılı");
            

        }

        private void FrmMustDuzenle_Load(object sender, EventArgs e)
        {
            TxtMustId.Text = id;
            TxtMustAd.Text = ad;
            TxtMustSoyad.Text = soyad;
            MskTC.Text = tc;
            MskMustTelefon.Text = tel;
            MskMustDogum.Text = dgm_trh;
            CmbSehir.Text = sehir;
            TxtMail.Text = mail;
            CmbOdaNo.Text = odano;
            TxtOdaSure.Text = sure;
            RchAdres.Text = adres;
            
        }
    }
}

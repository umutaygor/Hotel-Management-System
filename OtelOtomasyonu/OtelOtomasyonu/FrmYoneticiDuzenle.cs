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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet4.Yonetici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yoneticiTableAdapter.Fill(this.otelOtomasyonuDataSet4.Yonetici);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Yonetici (YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYoneticiSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi");
            this.yoneticiTableAdapter.Fill(this.otelOtomasyonuDataSet4.Yonetici);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id,ad, sifre;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre=dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtYoneticiId.Text = id;
            TxtYoneticiAd.Text = ad;
            TxtYoneticiSifre.Text = sifre;  
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("delete from Yonetici where Yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Silindi");
            TxtYoneticiId.Clear();
            TxtYoneticiAd.Clear();
            TxtYoneticiSifre.Clear();
            this.yoneticiTableAdapter.Fill(this.otelOtomasyonuDataSet4.Yonetici);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Yonetici set YoneticiAd=@p1,YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYoneticiSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Güncellendi");
            this.yoneticiTableAdapter.Fill(this.otelOtomasyonuDataSet4.Yonetici);
        }
    }
}

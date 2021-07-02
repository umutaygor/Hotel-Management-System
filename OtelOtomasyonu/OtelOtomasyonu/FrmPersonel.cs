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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonelcs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet8.Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter3.Fill(this.otelOtomasyonuDataSet8.Personel);




        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAd,PersonelSoyad,PersonelDepartman) values(@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonelDepartman.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi");
            this.personelTableAdapter3.Fill(this.otelOtomasyonuDataSet8.Personel);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Silindi");
            TxtPersonelid.Clear();
            TxtPersonelAd.Clear();
            TxtPersonelSoyad.Clear();
            TxtPersonelDepartman.Clear();
            this.personelTableAdapter3.Fill(this.otelOtomasyonuDataSet8.Personel);

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string id, ad,soyad, departman;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            departman = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtPersonelid.Text = id;
            TxtPersonelAd.Text = ad;
            TxtPersonelSoyad.Text = soyad;
            TxtPersonelDepartman.Text = departman;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personel set PersonelAd=@p1,PersonelSoyad=@p2,PersonelDepartman=@p3 where Personelid=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtPersonelDepartman.Text);
            komut.Parameters.AddWithValue("@p4", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Düzenlendi");
            this.personelTableAdapter3.Fill(this.otelOtomasyonuDataSet8.Personel);

        }
    }
}

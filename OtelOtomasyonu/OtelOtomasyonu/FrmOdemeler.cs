using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FrmOdemeler : Form
    {

        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet1.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.otelOtomasyonuDataSet1.Borclar);

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad,soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMustId.Text = id;
            TxtMustAd.Text = ad;
            TxtMustSoyad.Text = soyad;
            TxtKalanBorc.Text = kalan;
           

        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan borcdan düşme
            int odenen, kalan,yeniborc;
            odenen = Convert.ToUInt16(TxtOdenen.Text);
            kalan = Convert.ToUInt16(TxtKalanBorc.Text);
            yeniborc = kalan - odenen;
            TxtKalanBorc.Text = yeniborc.ToString();


            //Yeni tutarı veritabanında güncelleme
            SqlCommand komut = new SqlCommand("update Borclar set MustKalanBorc=@p1 where Mustid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtMustId.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter.Fill(this.otelOtomasyonuDataSet1.Borclar);
            /* Kasa tablosuna ekleme yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeTarih,OdemeMiktar) values (@k1,@k2)",bgl.baglanti());

            komut2.Parameters.AddWithValue("@k1", TxtOdenenTarih.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close(); */

            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeTarih,OdemeAy,OdemeMiktar) values (@k1,@k2,@k3)", bgl.baglanti());

            string theDate = dateTimePicker1.Value.ToString("MM-yyyy");
            komut2.Parameters.AddWithValue("@k1", dateTimePicker1.Text);
            komut2.Parameters.AddWithValue("@k2", theDate);
            komut2.Parameters.AddWithValue("@k3", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close(); 
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

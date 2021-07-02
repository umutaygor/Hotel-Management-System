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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        
       
        private void MusteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MustListesi fr = new MustListesi();
            fr.Show();
        }

        private void MusteriDüzenlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MustListesi fr = new MustListesi();
            fr.Show();
        }

        public void dgdoldur()
        {
            this.musteriTableAdapter.Fill(this.otelOtomasyonuDataSet.Musteri);
            timer1.Start();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otelOtomasyonuDataSet.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            
            
            SqlCommand komutbar = new SqlCommand("Select Count (Odaid) from Odalar where OdaAktif!=0 ", bgl.baglanti());
            Int32 count = Convert.ToInt32(komutbar.ExecuteScalar());
            label3.Text ="Otel Doluluk Oranı=% "+Convert.ToString(count.ToString());
            progressBar1.Value = count;
            dgdoldur();
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void MusteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMustKayit fr = new FrmMustKayit();
            fr.Show();

        }

        private void ÖdemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.Show();
        }

        private void GiderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider fr = new FrmGider();
            fr.Show();
        }

        private void GiderListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi fr = new FrmGiderListesi();
            fr.Show();
        }

        private void ÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirİstatistik fr = new FrmGelirİstatistik();
            fr.Show();
        }

       

        private void ŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr = new FrmYoneticiDuzenle();
            fr.Show();
        }

        private void PersonelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel fr = new FrmPersonel();
            fr.Show();
        }

        private void HesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ResimÇizmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MustListesi fr = new MustListesi();
            fr.Show();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dgdoldur();
        }

        private void UygulamaPenceresiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Uygulama Umut Aygör Tarafından Görsel Programlama Dersi Projesi İçin Yapılmıştır", "Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void YöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

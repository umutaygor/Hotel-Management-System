namespace OtelOtomasyonu
{
    partial class MustListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MustListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mustidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mustSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelOtomasyonuDataSet2 = new OtelOtomasyonu.OtelOtomasyonuDataSet2();
            this.musteriTableAdapter = new OtelOtomasyonu.OtelOtomasyonuDataSet2TableAdapters.MusteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mustidDataGridViewTextBoxColumn,
            this.mustAdDataGridViewTextBoxColumn,
            this.mustSoyadDataGridViewTextBoxColumn,
            this.mustTCDataGridViewTextBoxColumn,
            this.mustTelDataGridViewTextBoxColumn,
            this.mustDogumDataGridViewTextBoxColumn,
            this.mustSehirDataGridViewTextBoxColumn,
            this.mustMailDataGridViewTextBoxColumn,
            this.mustOdaNoDataGridViewTextBoxColumn,
            this.mustAdresDataGridViewTextBoxColumn,
            this.mustSureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1524, 613);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // mustidDataGridViewTextBoxColumn
            // 
            this.mustidDataGridViewTextBoxColumn.DataPropertyName = "Mustid";
            this.mustidDataGridViewTextBoxColumn.HeaderText = "Mustid";
            this.mustidDataGridViewTextBoxColumn.Name = "mustidDataGridViewTextBoxColumn";
            this.mustidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mustAdDataGridViewTextBoxColumn
            // 
            this.mustAdDataGridViewTextBoxColumn.DataPropertyName = "MustAd";
            this.mustAdDataGridViewTextBoxColumn.HeaderText = "MustAd";
            this.mustAdDataGridViewTextBoxColumn.Name = "mustAdDataGridViewTextBoxColumn";
            // 
            // mustSoyadDataGridViewTextBoxColumn
            // 
            this.mustSoyadDataGridViewTextBoxColumn.DataPropertyName = "MustSoyad";
            this.mustSoyadDataGridViewTextBoxColumn.HeaderText = "MustSoyad";
            this.mustSoyadDataGridViewTextBoxColumn.Name = "mustSoyadDataGridViewTextBoxColumn";
            // 
            // mustTCDataGridViewTextBoxColumn
            // 
            this.mustTCDataGridViewTextBoxColumn.DataPropertyName = "MustTC";
            this.mustTCDataGridViewTextBoxColumn.HeaderText = "MustTC";
            this.mustTCDataGridViewTextBoxColumn.Name = "mustTCDataGridViewTextBoxColumn";
            // 
            // mustTelDataGridViewTextBoxColumn
            // 
            this.mustTelDataGridViewTextBoxColumn.DataPropertyName = "MustTel";
            this.mustTelDataGridViewTextBoxColumn.HeaderText = "MustTel";
            this.mustTelDataGridViewTextBoxColumn.Name = "mustTelDataGridViewTextBoxColumn";
            // 
            // mustDogumDataGridViewTextBoxColumn
            // 
            this.mustDogumDataGridViewTextBoxColumn.DataPropertyName = "MustDogum";
            this.mustDogumDataGridViewTextBoxColumn.HeaderText = "MustDogum";
            this.mustDogumDataGridViewTextBoxColumn.Name = "mustDogumDataGridViewTextBoxColumn";
            // 
            // mustSehirDataGridViewTextBoxColumn
            // 
            this.mustSehirDataGridViewTextBoxColumn.DataPropertyName = "MustSehir";
            this.mustSehirDataGridViewTextBoxColumn.HeaderText = "MustSehir";
            this.mustSehirDataGridViewTextBoxColumn.Name = "mustSehirDataGridViewTextBoxColumn";
            // 
            // mustMailDataGridViewTextBoxColumn
            // 
            this.mustMailDataGridViewTextBoxColumn.DataPropertyName = "MustMail";
            this.mustMailDataGridViewTextBoxColumn.HeaderText = "MustMail";
            this.mustMailDataGridViewTextBoxColumn.Name = "mustMailDataGridViewTextBoxColumn";
            // 
            // mustOdaNoDataGridViewTextBoxColumn
            // 
            this.mustOdaNoDataGridViewTextBoxColumn.DataPropertyName = "MustOdaNo";
            this.mustOdaNoDataGridViewTextBoxColumn.HeaderText = "MustOdaNo";
            this.mustOdaNoDataGridViewTextBoxColumn.Name = "mustOdaNoDataGridViewTextBoxColumn";
            // 
            // mustAdresDataGridViewTextBoxColumn
            // 
            this.mustAdresDataGridViewTextBoxColumn.DataPropertyName = "MustAdres";
            this.mustAdresDataGridViewTextBoxColumn.HeaderText = "MustAdres";
            this.mustAdresDataGridViewTextBoxColumn.Name = "mustAdresDataGridViewTextBoxColumn";
            // 
            // mustSureDataGridViewTextBoxColumn
            // 
            this.mustSureDataGridViewTextBoxColumn.DataPropertyName = "MustSure";
            this.mustSureDataGridViewTextBoxColumn.HeaderText = "MustSure";
            this.mustSureDataGridViewTextBoxColumn.Name = "mustSureDataGridViewTextBoxColumn";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.otelOtomasyonuDataSet2;
            // 
            // otelOtomasyonuDataSet2
            // 
            this.otelOtomasyonuDataSet2.DataSetName = "OtelOtomasyonuDataSet2";
            this.otelOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // MustListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1524, 613);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MustListesi";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.MustListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelOtomasyonuDataSet2 otelOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private OtelOtomasyonuDataSet2TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mustSureDataGridViewTextBoxColumn;
    }
}
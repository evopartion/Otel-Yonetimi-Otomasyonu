namespace Otel_Otomasyonu
{
    partial class Aşci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaYemekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.çorbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.içecekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatlıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazirlaniyorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet12 = new Otel_Otomasyonu.OtelDataSet12();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.siparisidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odanoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hazirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet8 = new Otel_Otomasyonu.OtelDataSet8();
            this.hazirlaniyorTableAdapter = new Otel_Otomasyonu.OtelDataSet12TableAdapters.HazirlaniyorTableAdapter();
            this.hazirTableAdapter = new Otel_Otomasyonu.OtelDataSet8TableAdapters.HazirTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazirlaniyorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet12)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sipariş Durumu:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hazır",
            "İptal"});
            this.comboBox1.Location = new System.Drawing.Point(181, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teslim Et";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Garsona Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1141, 286);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hazırlanan Siparişler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisidDataGridViewTextBoxColumn,
            this.odanoDataGridViewTextBoxColumn,
            this.anaYemekDataGridViewTextBoxColumn,
            this.çorbaDataGridViewTextBoxColumn,
            this.içecekDataGridViewTextBoxColumn,
            this.tatlıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hazirlaniyorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // siparisidDataGridViewTextBoxColumn
            // 
            this.siparisidDataGridViewTextBoxColumn.DataPropertyName = "siparis_id";
            this.siparisidDataGridViewTextBoxColumn.HeaderText = "siparis_id";
            this.siparisidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siparisidDataGridViewTextBoxColumn.Name = "siparisidDataGridViewTextBoxColumn";
            this.siparisidDataGridViewTextBoxColumn.Width = 125;
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "oda_no";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "oda_no";
            this.odanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            this.odanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // anaYemekDataGridViewTextBoxColumn
            // 
            this.anaYemekDataGridViewTextBoxColumn.DataPropertyName = "AnaYemek";
            this.anaYemekDataGridViewTextBoxColumn.HeaderText = "AnaYemek";
            this.anaYemekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anaYemekDataGridViewTextBoxColumn.Name = "anaYemekDataGridViewTextBoxColumn";
            this.anaYemekDataGridViewTextBoxColumn.Width = 125;
            // 
            // çorbaDataGridViewTextBoxColumn
            // 
            this.çorbaDataGridViewTextBoxColumn.DataPropertyName = "Çorba";
            this.çorbaDataGridViewTextBoxColumn.HeaderText = "Çorba";
            this.çorbaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.çorbaDataGridViewTextBoxColumn.Name = "çorbaDataGridViewTextBoxColumn";
            this.çorbaDataGridViewTextBoxColumn.Width = 125;
            // 
            // içecekDataGridViewTextBoxColumn
            // 
            this.içecekDataGridViewTextBoxColumn.DataPropertyName = "İçecek";
            this.içecekDataGridViewTextBoxColumn.HeaderText = "İçecek";
            this.içecekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.içecekDataGridViewTextBoxColumn.Name = "içecekDataGridViewTextBoxColumn";
            this.içecekDataGridViewTextBoxColumn.Width = 125;
            // 
            // tatlıDataGridViewTextBoxColumn
            // 
            this.tatlıDataGridViewTextBoxColumn.DataPropertyName = "Tatlı";
            this.tatlıDataGridViewTextBoxColumn.HeaderText = "Tatlı";
            this.tatlıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tatlıDataGridViewTextBoxColumn.Name = "tatlıDataGridViewTextBoxColumn";
            this.tatlıDataGridViewTextBoxColumn.Width = 125;
            // 
            // hazirlaniyorBindingSource
            // 
            this.hazirlaniyorBindingSource.DataMember = "Hazirlaniyor";
            this.hazirlaniyorBindingSource.DataSource = this.otelDataSet12;
            // 
            // otelDataSet12
            // 
            this.otelDataSet12.DataSetName = "OtelDataSet12";
            this.otelDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(421, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 230);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teslim Edilenler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisidDataGridViewTextBoxColumn1,
            this.odanoDataGridViewTextBoxColumn1,
            this.durumuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.hazirBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(726, 209);
            this.dataGridView2.TabIndex = 0;
            // 
            // siparisidDataGridViewTextBoxColumn1
            // 
            this.siparisidDataGridViewTextBoxColumn1.DataPropertyName = "siparis_id";
            this.siparisidDataGridViewTextBoxColumn1.HeaderText = "siparis_id";
            this.siparisidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.siparisidDataGridViewTextBoxColumn1.Name = "siparisidDataGridViewTextBoxColumn1";
            this.siparisidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // odanoDataGridViewTextBoxColumn1
            // 
            this.odanoDataGridViewTextBoxColumn1.DataPropertyName = "oda_no";
            this.odanoDataGridViewTextBoxColumn1.HeaderText = "oda_no";
            this.odanoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn1.Name = "odanoDataGridViewTextBoxColumn1";
            this.odanoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // durumuDataGridViewTextBoxColumn
            // 
            this.durumuDataGridViewTextBoxColumn.DataPropertyName = "durumu";
            this.durumuDataGridViewTextBoxColumn.HeaderText = "durumu";
            this.durumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumuDataGridViewTextBoxColumn.Name = "durumuDataGridViewTextBoxColumn";
            this.durumuDataGridViewTextBoxColumn.Width = 125;
            // 
            // hazirBindingSource
            // 
            this.hazirBindingSource.DataMember = "Hazir";
            this.hazirBindingSource.DataSource = this.otelDataSet8;
            // 
            // otelDataSet8
            // 
            this.otelDataSet8.DataSetName = "OtelDataSet8";
            this.otelDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hazirlaniyorTableAdapter
            // 
            this.hazirlaniyorTableAdapter.ClearBeforeFill = true;
            // 
            // hazirTableAdapter
            // 
            this.hazirTableAdapter.ClearBeforeFill = true;
            // 
            // Aşci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1165, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Aşci";
            this.Text = "Aşci";
            this.Load += new System.EventHandler(this.Aşci_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazirlaniyorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet12)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hazirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelDataSet12 otelDataSet12;
        private System.Windows.Forms.BindingSource hazirlaniyorBindingSource;
        private OtelDataSet12TableAdapters.HazirlaniyorTableAdapter hazirlaniyorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anaYemekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn çorbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn içecekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatlıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private OtelDataSet8 otelDataSet8;
        private System.Windows.Forms.BindingSource hazirBindingSource;
        private OtelDataSet8TableAdapters.HazirTableAdapter hazirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumuDataGridViewTextBoxColumn;
    }
}
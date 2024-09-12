namespace Otel_Otomasyonu
{
    partial class Yönetici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odanoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet3 = new Otel_Otomasyonu.OtelDataSet3();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.odanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şikayetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.görüşüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bildirimlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet2 = new Otel_Otomasyonu.OtelDataSet2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bildirimlerTableAdapter = new Otel_Otomasyonu.OtelDataSet2TableAdapters.BildirimlerTableAdapter();
            this.odemelerTableAdapter = new Otel_Otomasyonu.OtelDataSet3TableAdapters.OdemelerTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.padDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet4 = new Otel_Otomasyonu.OtelDataSet4();
            this.personellerTableAdapter = new Otel_Otomasyonu.OtelDataSet4TableAdapters.PersonellerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odanoDataGridViewTextBoxColumn1,
            this.tutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(848, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 522);
            this.dataGridView1.TabIndex = 0;
            // 
            // odanoDataGridViewTextBoxColumn1
            // 
            this.odanoDataGridViewTextBoxColumn1.DataPropertyName = "oda_no";
            this.odanoDataGridViewTextBoxColumn1.HeaderText = "oda_no";
            this.odanoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn1.Name = "odanoDataGridViewTextBoxColumn1";
            this.odanoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            this.tutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemelerBindingSource
            // 
            this.odemelerBindingSource.DataMember = "Odemeler";
            this.odemelerBindingSource.DataSource = this.otelDataSet3;
            // 
            // otelDataSet3
            // 
            this.otelDataSet3.DataSetName = "OtelDataSet3";
            this.otelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odanoDataGridViewTextBoxColumn,
            this.şikayetiDataGridViewTextBoxColumn,
            this.görüşüDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bildirimlerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 292);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(434, 242);
            this.dataGridView2.TabIndex = 1;
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "oda_no";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "oda_no";
            this.odanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            this.odanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // şikayetiDataGridViewTextBoxColumn
            // 
            this.şikayetiDataGridViewTextBoxColumn.DataPropertyName = "Şikayeti";
            this.şikayetiDataGridViewTextBoxColumn.HeaderText = "Şikayeti";
            this.şikayetiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.şikayetiDataGridViewTextBoxColumn.Name = "şikayetiDataGridViewTextBoxColumn";
            this.şikayetiDataGridViewTextBoxColumn.Width = 125;
            // 
            // görüşüDataGridViewTextBoxColumn
            // 
            this.görüşüDataGridViewTextBoxColumn.DataPropertyName = "Görüşü";
            this.görüşüDataGridViewTextBoxColumn.HeaderText = "Görüşü";
            this.görüşüDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.görüşüDataGridViewTextBoxColumn.Name = "görüşüDataGridViewTextBoxColumn";
            this.görüşüDataGridViewTextBoxColumn.Width = 125;
            // 
            // bildirimlerBindingSource
            // 
            this.bildirimlerBindingSource.DataMember = "Bildirimler";
            this.bildirimlerBindingSource.DataSource = this.otelDataSet2;
            // 
            // otelDataSet2
            // 
            this.otelDataSet2.DataSetName = "OtelDataSet2";
            this.otelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödemeler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Net Kazanç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sponsor Gelir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diğer Gelirler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Maaş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Gelir:";
            // 
            // bildirimlerTableAdapter
            // 
            this.bildirimlerTableAdapter.ClearBeforeFill = true;
            // 
            // odemelerTableAdapter
            // 
            this.odemelerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.padDataGridViewTextBoxColumn,
            this.psoyadDataGridViewTextBoxColumn,
            this.pmaasDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.personellerBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(452, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(390, 522);
            this.dataGridView3.TabIndex = 3;
            // 
            // padDataGridViewTextBoxColumn
            // 
            this.padDataGridViewTextBoxColumn.DataPropertyName = "p_ad";
            this.padDataGridViewTextBoxColumn.HeaderText = "p_ad";
            this.padDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.padDataGridViewTextBoxColumn.Name = "padDataGridViewTextBoxColumn";
            this.padDataGridViewTextBoxColumn.Width = 125;
            // 
            // psoyadDataGridViewTextBoxColumn
            // 
            this.psoyadDataGridViewTextBoxColumn.DataPropertyName = "p_soyad";
            this.psoyadDataGridViewTextBoxColumn.HeaderText = "p_soyad";
            this.psoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.psoyadDataGridViewTextBoxColumn.Name = "psoyadDataGridViewTextBoxColumn";
            this.psoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // pmaasDataGridViewTextBoxColumn
            // 
            this.pmaasDataGridViewTextBoxColumn.DataPropertyName = "p_maas";
            this.pmaasDataGridViewTextBoxColumn.HeaderText = "p_maas";
            this.pmaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pmaasDataGridViewTextBoxColumn.Name = "pmaasDataGridViewTextBoxColumn";
            this.pmaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "Personeller";
            this.personellerBindingSource.DataSource = this.otelDataSet4;
            // 
            // otelDataSet4
            // 
            this.otelDataSet4.DataSetName = "OtelDataSet4";
            this.otelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // Yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1165, 546);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Yönetici";
            this.Text = "Yönetici";
            this.Load += new System.EventHandler(this.Yönetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private OtelDataSet2 otelDataSet2;
        private System.Windows.Forms.BindingSource bildirimlerBindingSource;
        private OtelDataSet2TableAdapters.BildirimlerTableAdapter bildirimlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şikayetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn görüşüDataGridViewTextBoxColumn;
        private OtelDataSet3 otelDataSet3;
        private System.Windows.Forms.BindingSource odemelerBindingSource;
        private OtelDataSet3TableAdapters.OdemelerTableAdapter odemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private OtelDataSet4 otelDataSet4;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private OtelDataSet4TableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn padDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmaasDataGridViewTextBoxColumn;
    }
}
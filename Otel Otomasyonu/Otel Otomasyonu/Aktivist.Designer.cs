namespace Otel_Otomasyonu
{
    partial class Aktivist
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etkinlikAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikÜcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinliklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet6 = new Otel_Otomasyonu.OtelDataSet6();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.odanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikAdıDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gezeceklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet7 = new Otel_Otomasyonu.OtelDataSet7();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.etkinliklerTableAdapter = new Otel_Otomasyonu.OtelDataSet6TableAdapters.EtkinliklerTableAdapter();
            this.gezeceklerTableAdapter = new Otel_Otomasyonu.OtelDataSet7TableAdapters.GezeceklerTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinliklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gezeceklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet7)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(108, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Etkinlik Ekle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Etkinlik Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Etkinlik Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ücreti:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etkinlikAdıDataGridViewTextBoxColumn,
            this.etkinlikTarihiDataGridViewTextBoxColumn,
            this.etkinlikÜcretiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etkinliklerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 218);
            this.dataGridView1.TabIndex = 1;
            // 
            // etkinlikAdıDataGridViewTextBoxColumn
            // 
            this.etkinlikAdıDataGridViewTextBoxColumn.DataPropertyName = "Etkinlik_Adı";
            this.etkinlikAdıDataGridViewTextBoxColumn.HeaderText = "Etkinlik_Adı";
            this.etkinlikAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etkinlikAdıDataGridViewTextBoxColumn.Name = "etkinlikAdıDataGridViewTextBoxColumn";
            this.etkinlikAdıDataGridViewTextBoxColumn.Width = 125;
            // 
            // etkinlikTarihiDataGridViewTextBoxColumn
            // 
            this.etkinlikTarihiDataGridViewTextBoxColumn.DataPropertyName = "Etkinlik_Tarihi";
            this.etkinlikTarihiDataGridViewTextBoxColumn.HeaderText = "Etkinlik_Tarihi";
            this.etkinlikTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etkinlikTarihiDataGridViewTextBoxColumn.Name = "etkinlikTarihiDataGridViewTextBoxColumn";
            this.etkinlikTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // etkinlikÜcretiDataGridViewTextBoxColumn
            // 
            this.etkinlikÜcretiDataGridViewTextBoxColumn.DataPropertyName = "Etkinlik_Ücreti";
            this.etkinlikÜcretiDataGridViewTextBoxColumn.HeaderText = "Etkinlik_Ücreti";
            this.etkinlikÜcretiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etkinlikÜcretiDataGridViewTextBoxColumn.Name = "etkinlikÜcretiDataGridViewTextBoxColumn";
            this.etkinlikÜcretiDataGridViewTextBoxColumn.Width = 125;
            // 
            // etkinliklerBindingSource
            // 
            this.etkinliklerBindingSource.DataMember = "Etkinlikler";
            this.etkinliklerBindingSource.DataSource = this.otelDataSet6;
            // 
            // otelDataSet6
            // 
            this.otelDataSet6.DataSetName = "OtelDataSet6";
            this.otelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odanoDataGridViewTextBoxColumn,
            this.etkinlikAdıDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.gezeceklerBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(410, 501);
            this.dataGridView2.TabIndex = 2;
            // 
            // odanoDataGridViewTextBoxColumn
            // 
            this.odanoDataGridViewTextBoxColumn.DataPropertyName = "oda_no";
            this.odanoDataGridViewTextBoxColumn.HeaderText = "oda_no";
            this.odanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanoDataGridViewTextBoxColumn.Name = "odanoDataGridViewTextBoxColumn";
            this.odanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // etkinlikAdıDataGridViewTextBoxColumn1
            // 
            this.etkinlikAdıDataGridViewTextBoxColumn1.DataPropertyName = "Etkinlik_Adı";
            this.etkinlikAdıDataGridViewTextBoxColumn1.HeaderText = "Etkinlik_Adı";
            this.etkinlikAdıDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.etkinlikAdıDataGridViewTextBoxColumn1.Name = "etkinlikAdıDataGridViewTextBoxColumn1";
            this.etkinlikAdıDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gezeceklerBindingSource
            // 
            this.gezeceklerBindingSource.DataMember = "Gezecekler";
            this.gezeceklerBindingSource.DataSource = this.otelDataSet7;
            // 
            // otelDataSet7
            // 
            this.otelDataSet7.DataSetName = "OtelDataSet7";
            this.otelDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(660, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 522);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etkinliklere Katılacaklar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(108, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 239);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Güncel Etkinlikler";
            // 
            // etkinliklerTableAdapter
            // 
            this.etkinliklerTableAdapter.ClearBeforeFill = true;
            // 
            // gezeceklerTableAdapter
            // 
            this.gezeceklerTableAdapter.ClearBeforeFill = true;
            // 
            // Aktivist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1165, 546);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Aktivist";
            this.Text = "Aktivist";
            this.Load += new System.EventHandler(this.Aktivist_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinliklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gezeceklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet7)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private OtelDataSet6 otelDataSet6;
        private System.Windows.Forms.BindingSource etkinliklerBindingSource;
        private OtelDataSet6TableAdapters.EtkinliklerTableAdapter etkinliklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikÜcretiDataGridViewTextBoxColumn;
        private OtelDataSet7 otelDataSet7;
        private System.Windows.Forms.BindingSource gezeceklerBindingSource;
        private OtelDataSet7TableAdapters.GezeceklerTableAdapter gezeceklerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikAdıDataGridViewTextBoxColumn1;
    }
}
﻿namespace Otel_Otomasyonu
{
    partial class Müşteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Müşteri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etkinlikAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinlikÜcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinliklerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelDataSet1 = new Otel_Otomasyonu.OtelDataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.etkinliklerTableAdapter = new Otel_Otomasyonu.OtelDataSet1TableAdapters.EtkinliklerTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinliklerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oda Siparişi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sipariş Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Tatlı İstemiyorum.",
            "Künefe",
            "Ekmek Kadayıfı",
            "Tulumba Tatlısı",
            "Mozaik Kek",
            "Baklava",
            "Sütlaç"});
            this.comboBox4.Location = new System.Drawing.Point(160, 150);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "İçecek İstemiyorum.",
            "Fanta",
            "Gazoz",
            "Ayran",
            "Meyve Suyu",
            "Kola",
            "Çay"});
            this.comboBox3.Location = new System.Drawing.Point(160, 120);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Çorba İstemiyorum.",
            "Mercimek Çorbası ",
            "Domates Çorbası",
            "Tarhana Çorbası",
            "Yayla Çorbası",
            "Arpa şehriye Çorbası",
            "İnceğiz Çorbası"});
            this.comboBox2.Location = new System.Drawing.Point(160, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ana Yemek İstemiyorum.",
            "Beypazarı Güveci",
            "Beyti Kebap",
            "Ankara Tava",
            "Biber Dolması",
            "İskender",
            "Entekke Böreği"});
            this.comboBox1.Location = new System.Drawing.Point(160, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tutar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tatlı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "İçecek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çorba:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ana Yemek:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(348, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etkinlikler";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Kayıt Ol";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(114, 202);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(157, 24);
            this.comboBox5.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Etkinlik Seçin:";
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(439, 166);
            this.dataGridView1.TabIndex = 0;
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
            this.etkinliklerBindingSource.DataSource = this.otelDataSet1;
            // 
            // otelDataSet1
            // 
            this.otelDataSet1.DataSetName = "OtelDataSet1";
            this.otelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox3.Location = new System.Drawing.Point(819, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 343);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Radyo";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 21);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(324, 240);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "ANKARA HAVALARI",
            "BEST FM",
            "90\'LAR",
            "KAYSERİ GÖZDE FM",
            "NUMBER1 FM"});
            this.comboBox6.Location = new System.Drawing.Point(825, 408);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(298, 24);
            this.comboBox6.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(822, 445);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Şuan Bu Kanaldasınız:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(821, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 22);
            this.label14.TabIndex = 1;
            this.label14.Text = "Kanal Seçin:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 158);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şikayet ve Görüşleriniz";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bildir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 72);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(637, 33);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 33);
            this.textBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Görüşünüz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şikayetiniz:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(20, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 36);
            this.label9.TabIndex = 1;
            this.label9.Text = "Wİ-Fİ ŞİFRESİ: S061389";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Oda No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(142, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 38);
            this.label11.TabIndex = 3;
            this.label11.Text = "label11";
            // 
            // etkinliklerTableAdapter
            // 
            this.etkinliklerTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(562, 456);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 29);
            this.label16.TabIndex = 4;
            this.label16.Text = "Faturam:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(683, 456);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 29);
            this.label17.TabIndex = 5;
            this.label17.Text = "label17";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "Fatura Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(970, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Oynat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(967, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 8;
            this.label18.Text = "label18";
            // 
            // Müşteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1285, 546);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Müşteri";
            this.Text = "Müşteri";
            this.Load += new System.EventHandler(this.Müşteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etkinliklerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OtelDataSet1 otelDataSet1;
        private System.Windows.Forms.BindingSource etkinliklerBindingSource;
        private OtelDataSet1TableAdapters.EtkinliklerTableAdapter etkinliklerTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinlikÜcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label18;
    }
}
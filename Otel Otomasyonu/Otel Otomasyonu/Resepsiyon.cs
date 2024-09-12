using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_Otomasyonu
{
    public partial class Resepsiyon : Form
    {
        public Resepsiyon()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");

        private void IK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.otelDataSet.Musteriler);
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM bos_odalar", baglan);
            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["bos_yerler"]);
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.otelDataSet.Musteriler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into Musteriler (m_ad,m_soyad,m_tc,m_telefon,m_giris,m_cikis,m_gun,m_oda) values (@ad,@soy,@tc,@tel,@gir,@cik,@gun,@oda)", baglan);
            ekle.Parameters.AddWithValue("@ad", textBox1.Text);
            ekle.Parameters.AddWithValue("@soy", textBox2.Text);
            ekle.Parameters.AddWithValue("@tc", maskedTextBox1.Text);
            ekle.Parameters.AddWithValue("@tel", maskedTextBox2.Text);
            ekle.Parameters.AddWithValue("@gir", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@cik", dateTimePicker2.Value);
            ekle.Parameters.AddWithValue("@gun", label8.Text);
            ekle.Parameters.AddWithValue("@oda", comboBox1.SelectedItem);
            ekle.ExecuteNonQuery();
            ekle.CommandText = "insert into dolu_odalar(dolu_yerler) VALUES ('" + comboBox1.Text + "')";
            ekle.ExecuteNonQuery();
            ekle.CommandText = ("delete from bos_odalar where bos_yerler='" + comboBox1.Text + "'");
            ekle.ExecuteNonQuery();
            
            SqlCommand gunluk = new SqlCommand("insert Odemeler (oda_no,tutar) VALUES (@mo,@mot)", baglan);
            gunluk.Parameters.AddWithValue("@mo", comboBox1.Text);
            gunluk.Parameters.AddWithValue("@mot", Convert.ToInt32(label8.Text) * 500);
            gunluk.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kayıt eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from musteriler where m_tc=@sil", baglan);
            sil.Parameters.AddWithValue("@sil", maskedTextBox1.Text);
            sil.ExecuteNonQuery();
            sil.CommandText = "insert into bos_odalar(bos_yerler) VALUES ('" + comboBox1.Text + "')";
            sil.ExecuteNonQuery();
            sil.CommandText = ("delete from dolu_odalar where dolu_yerler='" + comboBox1.Text + "'");
            sil.ExecuteNonQuery();
            sil.CommandText = ("delete from Odemeler where oda_no='" + comboBox1.Text + "'");
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kayıt silindi");
            maskedTextBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncelle = new SqlCommand("Update Musteriler Set m_ad=@m1,m_soyad=@m2,m_tc=@m3,m_telefon=@m4,m_oda=@m5,m_giris=@m6,m_cikis=@m7,m_gun=@m8 where m_tc=@m3 ", baglan);
            guncelle.Parameters.AddWithValue("@m1", textBox1.Text);
            guncelle.Parameters.AddWithValue("@m2", textBox2.Text);
            guncelle.Parameters.AddWithValue("@m3", maskedTextBox1.Text);
            guncelle.Parameters.AddWithValue("@m4", maskedTextBox2.Text);
            guncelle.Parameters.AddWithValue("@m5", comboBox1.Text);
            guncelle.Parameters.AddWithValue("@m6", dateTimePicker1.Value);
            guncelle.Parameters.AddWithValue("@m7", dateTimePicker2.Value);
            guncelle.Parameters.AddWithValue("@m8", label8.Text);
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            baglan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            dateTimePicker1.Text = default;
            dateTimePicker2.Text = default;
            comboBox1.Text = "";
            label8.Text = "";
            textBox1.Focus();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark = dateTimePicker2.Value - dateTimePicker1.Value;
            label8.Text = (fark.Days + 1).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}

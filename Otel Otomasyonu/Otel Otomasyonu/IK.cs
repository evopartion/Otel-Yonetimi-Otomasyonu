using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel_Otomasyonu
{
    public partial class IK : Form
    {
        public IK()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        private void IK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet5.Personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.otelDataSet5.Personeller);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet5.Personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.otelDataSet5.Personeller);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand per_ekle = new SqlCommand("insert into Personeller (p_ad,p_soyad,p_tc,p_cinsiyet,p_departman,p_maas) values (@pad,@psoyad,@ptc,@pcins,@pdep,@pmaas)", baglan);
            per_ekle.Parameters.AddWithValue("@pad", textBox1.Text);
            per_ekle.Parameters.AddWithValue("@psoyad", textBox2.Text);
            per_ekle.Parameters.AddWithValue("@ptc", maskedTextBox1.Text);
            per_ekle.Parameters.AddWithValue("@pcins", textBox3.Text);
            per_ekle.Parameters.AddWithValue("@pdep", comboBox1.SelectedItem);
            per_ekle.Parameters.AddWithValue("@pmaas", textBox4.Text);
            per_ekle.ExecuteNonQuery();
            MessageBox.Show("personel işe alındı");
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand per_sil = new SqlCommand("delete from Personeller where p_tc=@psil", baglan);
            per_sil.Parameters.AddWithValue("@psil", maskedTextBox1.Text);
            per_sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("personel işten çıkarıldı");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand per_guncelle = new SqlCommand("Update Personeller Set p_ad=@p_ad,p_soyad=@p_soyad,p_tc=@p_tc,p_cinsiyet=@p_cins,p_departman=@p_dep,p_maas=@p_maas where p_tc=@p_tc", baglan);
            per_guncelle.Parameters.AddWithValue("@p_ad", textBox1.Text);
            per_guncelle.Parameters.AddWithValue("@p_soyad", textBox2.Text);
            per_guncelle.Parameters.AddWithValue("@p_tc", maskedTextBox1.Text);
            per_guncelle.Parameters.AddWithValue("@p_cins", textBox3.Text);
            per_guncelle.Parameters.AddWithValue("@p_dep", comboBox1.Text);
            per_guncelle.Parameters.AddWithValue("@p_maas", textBox4.Text);

            per_guncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi");
            baglan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int per_secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[per_secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[per_secilen].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[per_secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[per_secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[per_secilen].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[per_secilen].Cells[5].Value.ToString();
        }
    }
}

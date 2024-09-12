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

namespace Otel_Otomasyonu
{
    public partial class Garson : Form
    {
        public Garson()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        private void Garson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet14.Siparisler' table. You can move, or remove it, as needed.
            this.siparislerTableAdapter2.Fill(this.otelDataSet14.Siparisler);
           
            
            // TODO: This line of code loads data into the 'otelDataSet8.Hazir' table. You can move, or remove it, as needed.
            this.hazirTableAdapter.Fill(this.otelDataSet8.Hazir);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into Hazirlaniyor (siparis_id,oda_no,AnaYemek,Çorba,İçecek,Tatlı) values (@sid,@ono,@ay,@cor,@ice,@tat)", baglan);

            ekle.Parameters.AddWithValue("@sid", textBox1.Text);
            ekle.Parameters.AddWithValue("@ono", textBox2.Text);
            ekle.Parameters.AddWithValue("@ay",  textBox3.Text);
            ekle.Parameters.AddWithValue("@cor", textBox4.Text);
            ekle.Parameters.AddWithValue("@ice", textBox5.Text);
            ekle.Parameters.AddWithValue("@tat", textBox6.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("yolladım");

            SqlCommand sil = new SqlCommand("delete from Siparisler where siparis_id=@sil",baglan);
            sil.Parameters.AddWithValue("@sil", textBox1.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Listeden kaldırıldı");
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet14.Siparisler' table. You can move, or remove it, as needed.
            this.siparislerTableAdapter2.Fill(this.otelDataSet14.Siparisler);
            // TODO: This line of code loads data into the 'otelDataSet8.Hazir' table. You can move, or remove it, as needed.
            this.hazirTableAdapter.Fill(this.otelDataSet8.Hazir);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}

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
    public partial class Aşci : Form
    {
        public Aşci()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        private void Aşci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet8.Hazir' table. You can move, or remove it, as needed.
            this.hazirTableAdapter.Fill(this.otelDataSet8.Hazir);
            // TODO: This line of code loads data into the 'otelDataSet12.Hazirlaniyor' table. You can move, or remove it, as needed.
            this.hazirlaniyorTableAdapter.Fill(this.otelDataSet12.Hazirlaniyor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into hazir (siparis_id,oda_no,durumu) values (@sid,@ono,@durum)", baglan);
            ekle.Parameters.AddWithValue("@sid", textBox1.Text);
            ekle.Parameters.AddWithValue("@ono", textBox2.Text);
            ekle.Parameters.AddWithValue("@durum", comboBox1.SelectedItem);
            ekle.ExecuteNonQuery();
            MessageBox.Show("garsona yolladık");
            ekle.CommandText = ("delete from hazirlaniyor where siparis_id=@sid");
            ekle.ExecuteNonQuery();
            MessageBox.Show("Listeden kaldırıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet8.Hazir' table. You can move, or remove it, as needed.
            this.hazirTableAdapter.Fill(this.otelDataSet8.Hazir);
            // TODO: This line of code loads data into the 'otelDataSet12.Hazirlaniyor' table. You can move, or remove it, as needed.
            this.hazirlaniyorTableAdapter.Fill(this.otelDataSet12.Hazirlaniyor);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}

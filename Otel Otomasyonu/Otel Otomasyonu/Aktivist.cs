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
    public partial class Aktivist : Form
    {
        public Aktivist()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into Etkinlikler (Etkinlik_Adı,Etkinlik_Tarihi,Etkinlik_Ücreti) values (@ea,@es,@eu)", baglan);
            ekle.Parameters.AddWithValue("@ea", textBox1.Text);
            ekle.Parameters.AddWithValue("@es", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("@eu", textBox2.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("eklendi");
            dataGridView2.Refresh();
            baglan.Close();
        }

        private void Aktivist_Load(object sender, EventArgs e)
        {
            otelDataSet6.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'otelDataSet7.Gezecekler' table. You can move, or remove it, as needed.
            this.gezeceklerTableAdapter.Fill(this.otelDataSet7.Gezecekler);
            // TODO: This line of code loads data into the 'otelDataSet6.Etkinlikler' table. You can move, or remove it, as needed.
            this.etkinliklerTableAdapter.Fill(this.otelDataSet6.Etkinlikler);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet6.Etkinlikler' table. You can move, or remove it, as needed.
            this.etkinliklerTableAdapter.Fill(this.otelDataSet6.Etkinlikler);
        }
    }
}

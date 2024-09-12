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
    public partial class Yönetici : Form
    {
        public Yönetici()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        private void Yönetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet4.Personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.otelDataSet4.Personeller);
            // TODO: This line of code loads data into the 'otelDataSet3.Odemeler' table. You can move, or remove it, as needed.
            this.odemelerTableAdapter.Fill(this.otelDataSet3.Odemeler);
            // TODO: This line of code loads data into the 'otelDataSet2.Bildirimler' table. You can move, or remove it, as needed.
            this.bildirimlerTableAdapter.Fill(this.otelDataSet2.Bildirimler);

            baglan.Open();
            int odenecek = 10000;
            long perodenecek = 0;
            long musgelecek = 0;
            int sponsor = 100000;

            SqlCommand personelode = new SqlCommand("SELECT SUM (p_maas) from Personeller", baglan);
            SqlDataReader dr1 = personelode.ExecuteReader();
            while (dr1.Read())
            {
                perodenecek += Convert.ToInt64(dr1[0]);
            }
            dr1.Close();
            SqlCommand musterigelir = new SqlCommand("SELECT SUM (tutar) from Odemeler", baglan);
            SqlDataReader dr2 = musterigelir.ExecuteReader();
            while (dr2.Read())
            {
                musgelecek += Convert.ToInt64(dr2[0]);
            }
            dr2.Close();
            label6.Text = musgelecek.ToString();
            label7.Text = perodenecek.ToString();
            label8.Text = odenecek.ToString();
            label9.Text = sponsor.ToString();
            label10.Text = (sponsor + musgelecek - perodenecek - odenecek).ToString();
            
            baglan.Close();

        }
    }
}

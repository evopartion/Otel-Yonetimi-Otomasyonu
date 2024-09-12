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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        Resepsiyon resepsiyon = new Resepsiyon();
        Müşteri müşteri = new Müşteri();
        Yönetici yönetici = new Yönetici();
        IK ik = new IK();
        Aktivist aktivist = new Aktivist();
        Garson garson = new Garson();
        Aşci aşçı = new Aşci();
        string m_oda;
        int odaucret;
        
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand giris = new SqlCommand("SELECT * FROM Personeller where p_departman=@departman and p_tc=@tc", baglan);
            giris.Parameters.AddWithValue("@departman", textBox1.Text);
            giris.Parameters.AddWithValue("@tc", textBox2.Text);
            SqlDataReader dr = giris.ExecuteReader();

            if (dr.Read())
            {
                
                
                this.Hide();

                if (textBox1.Text == "resepsiyon")
                {
                    resepsiyon.Show();
                }
                else if (textBox1.Text == "ik")
                {
                    ik.Show();
                }
                else if (textBox1.Text == "yonetici")
                {
                    yönetici.Show();
                }
                else if (textBox1.Text == "aktivist")
                {
                    aktivist.Show();
                }
                else if (textBox1.Text == "garson")
                {
                    garson.Show();
                }
                else if (textBox1.Text == "asci")
                {
                    aşçı.Show();
                }

                else
                {
                    MessageBox.Show("yanlış");
                }

            }
            else
            {
                MessageBox.Show("hata");
            }

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand musterigiris = new SqlCommand("SELECT * FROM Musteriler where m_telefon=@mtel and m_tc=@mtc", baglan);
            musterigiris.Parameters.AddWithValue("@mtel", textBox1.Text);
            musterigiris.Parameters.AddWithValue("@mtc", textBox2.Text);
            SqlDataReader dr1 = musterigiris.ExecuteReader();
            
                while (dr1.Read())
                {
                    m_oda = dr1["m_oda"].ToString();
                    odaucret = Convert.ToInt32(dr1["m_gun"]);
                    this.Hide();
                    müşteri.label11.Text = m_oda;
                    müşteri.Show();

                }
                dr1.Close();
            
            
            
            baglan.Close();
        }
        
    }
}

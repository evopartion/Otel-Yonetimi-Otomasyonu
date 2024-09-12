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

namespace Otel_Otomasyonu
{
    public partial class Müşteri : Form
    {
        public Müşteri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-59B37R3; Initial Catalog = Otel; Integrated Security = True");
        int ay_tutar = 0;
        int corba = 0;
        int tatli = 0;
        int icecek = 0;

        private void Müşteri_Load(object sender, EventArgs e)
        {
            otelDataSet1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'otelDataSet1.Etkinlikler' table. You can move, or remove it, as needed.
            this.etkinliklerTableAdapter.Fill(this.otelDataSet1.Etkinlikler);
            SqlCommand komut = new SqlCommand("SELECT * FROM Etkinlikler", baglan);
            SqlDataReader dr;
            baglan.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox5.Items.Add(dr["Etkinlik_Adı"]);
            }
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();


            SqlCommand gezi_ekle = new SqlCommand("insert into Gezecekler (oda_no,Etkinlik_Adı) values (@odaet,@etka)", baglan);
            gezi_ekle.Parameters.AddWithValue("@odaet", label11.Text);
            gezi_ekle.Parameters.AddWithValue("@etka", comboBox5.SelectedItem);
            gezi_ekle.ExecuteNonQuery();


            SqlCommand komut = new SqlCommand("select DISTINCT Etkinlik_Ücreti  from Etkinlikler where Etkinlik_Adı='" + comboBox5.Text + "'", baglan);
            SqlDataReader dr;

            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label13.Text = dr.GetValue(0).ToString();

            }
            dr.Close();

            SqlCommand geziborcu = new SqlCommand("insert into Odemeler (oda_no,tutar) VALUES (@odeno,@odetutar)", baglan);
            geziborcu.Parameters.AddWithValue("@odeno", label11.Text);
            geziborcu.Parameters.AddWithValue("@odetutar", label13.Text);
            geziborcu.ExecuteNonQuery();
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into Siparisler (oda_no,AnaYemek,Çorba,İçecek,Tatlı) values (@o_no,@ayemek,@cor,@ic,@tat)", baglan);
            ekle.Parameters.AddWithValue("@o_no", label11.Text);
            ekle.Parameters.AddWithValue("@ayemek", comboBox1.SelectedItem);
            ekle.Parameters.AddWithValue("@cor", comboBox2.SelectedItem);
            ekle.Parameters.AddWithValue("@ic", comboBox3.SelectedItem);
            ekle.Parameters.AddWithValue("@tat", comboBox4.SelectedItem);
            ekle.ExecuteNonQuery();


            SqlCommand borcekle = new SqlCommand("insert into Odemeler (oda_no,tutar) VALUES (@odeno,@odetutar)", baglan);
            borcekle.Parameters.AddWithValue("@odeno", label11.Text);
            borcekle.Parameters.AddWithValue("@odetutar", Convert.ToInt32(label6.Text) * 30);
            borcekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show(label6.Text + "TL Tutarındaki Siparişiniz Verildi.\nSiparişiniz:\n" + comboBox1.Text + "\n" + comboBox2.Text + "\n" + comboBox3.Text + "\n" + comboBox4.Text + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand talep = new SqlCommand("insert into Bildirimler (oda_no,Şikayeti,Görüşü) values (@o,@s,@g)", baglan);
            talep.Parameters.AddWithValue("@o", label11.Text);
            talep.Parameters.AddWithValue("@s", textBox1.Text);
            talep.Parameters.AddWithValue("@g", textBox2.Text);
            talep.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("talebiniz iletildi teşekkür ederiz");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand top_goster = new SqlCommand("SELECT SUM(tutar) FROM Odemeler where oda_no=@odaa", baglan);
            top_goster.Parameters.AddWithValue("@odaa", label11.Text);
            int dr2 = (int)top_goster.ExecuteScalar();
            label17.Text = dr2.ToString();


            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                ay_tutar += 0;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                ay_tutar += 25;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                ay_tutar += 20;

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                ay_tutar += 20;

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                ay_tutar += 10;

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                ay_tutar += 10;

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                ay_tutar += 10;

            }

            label6.Text = ay_tutar.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                corba += 0;

            }
            else if (comboBox2.SelectedIndex == 1)
            {
                corba += 5;

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                corba += 5;

            }
            else if (comboBox2.SelectedIndex == 3)
            {
                corba += 5;

            }
            else if (comboBox2.SelectedIndex == 4)
            {
                corba += 5;

            }
            else if (comboBox2.SelectedIndex == 5)
            {
                corba += 5;

            }
            else if (comboBox2.SelectedIndex == 6)
            {
                corba += 5;

            }

            label6.Text = (ay_tutar + corba).ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                icecek += 0;

            }
            else if (comboBox3.SelectedIndex == 1)
            {
                icecek += 3;

            }
            else if (comboBox3.SelectedIndex == 2)
            {
                icecek += 3;

            }
            else if (comboBox3.SelectedIndex == 3)
            {
                icecek += 1;

            }
            else if (comboBox3.SelectedIndex == 4)
            {
                icecek += 2;

            }
            else if (comboBox3.SelectedIndex == 5)
            {
                icecek += 3;

            }
            else if (comboBox3.SelectedIndex == 6)
            {
                icecek += 2;

            }

            label6.Text = (ay_tutar + corba + icecek).ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                tatli += 0;

            }
            else if (comboBox4.SelectedIndex == 1)
            {
                tatli += 7;

            }
            else if (comboBox4.SelectedIndex == 2)
            {
                tatli += 8;

            }
            else if (comboBox4.SelectedIndex == 3)
            {
                tatli += 6;

            }
            else if (comboBox4.SelectedIndex == 4)
            {
                tatli += 5;

            }
            else if (comboBox4.SelectedIndex == 5)
            {
                tatli += 10;

            }
            else if (comboBox4.SelectedIndex == 6)
            {
                tatli += 5;

            }

            int toplam = ay_tutar + corba + icecek + tatli;
            label6.Text = toplam.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            switch (comboBox6.SelectedIndex)
            {
                case 0: axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/30//";
                    label18.Text = "ANKARA HAVALARI";
                    break;
                case 1:
                    axWindowsMediaPlayer1.URL = "http://46.20.7.126/bestfmmp3";
                    label18.Text = "BEST FM";
                    break;
                case 2:
                    axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/";
                    label18.Text = "90'LAR";
                    break;
                case 3:
                    axWindowsMediaPlayer1.URL = "http://yayin1.yayindakiler.com:3056/;";
                    label18.Text = "KAYSERİ GÖZDE FM";
                    break;
                case 4:
                    axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/numberone";
                    label18.Text = "NUMBER1 FM";
                    break;
            }
            

        }
    }
}

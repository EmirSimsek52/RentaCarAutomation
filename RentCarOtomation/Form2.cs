using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentCarOtomation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=.\SQLEXPRESS;Initial Catalog=RentCar;Integrated Security=True";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into tablo1(Tc_No,Ad_Soyad,Telefon_Numarsu,Mail,Adres) Values(@Tc_No,@Ad_Soyad,@Telefon_Numarsu,@Mail,@Adres)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Tc_No", txtTcNo.Text);
            komut.Parameters.AddWithValue("@Ad_Soyad", txtAdSoy.Text);
            komut.Parameters.AddWithValue("@Telefon_Numarsu", txtTel.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text); 
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Basarili");
            txtMail.Text = "";
            txtTcNo.Text = "";
            txtAdSoy.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

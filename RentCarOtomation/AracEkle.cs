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
    public partial class AracEkle : Form
    {
        public AracEkle()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=.\SQLEXPRESS;Initial Catalog=RentCar;Integrated Security=True";


        private void pictureBox2Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracEkle_Load(object sender, EventArgs e)
        {
           

        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into tablo2(plaka,marka,model,yıl,renk,yakıt,kira,bakım,bakımkm,resim) Values(@plaka,@marka,@model,@yıl,@renk,@yakıt,@kira,@bakım,@bakımkm,@resim)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@plaKa", txtPlaka.Text);
            komut.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@model", txtModel.Text);
            komut.Parameters.AddWithValue("@yıl", txtYil.Text);
            komut.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@yakıt", txtYakit.Text);
            komut.Parameters.AddWithValue("@kira", txtKira.Text);
            komut.Parameters.AddWithValue("@bakım", txtBakim.Text);
            komut.Parameters.AddWithValue("@bakımkm", txtKm.Text);
            komut.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
          
            komut.ExecuteNonQuery();
 
            baglanti.Close();
            MessageBox.Show("Kayit Eklendi");
        }
    }
}

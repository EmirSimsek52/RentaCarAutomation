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
    public partial class Sozlesmeler : Form
    {
        public Sozlesmeler()
        {
            InitializeComponent();
        }
        private string baglantiCumlesi = @"Data Source=.\SQLEXPRESS;Initial Catalog=RentCar;Integrated Security=True";

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti= new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Insert Into tablo3(PLaka,Marka,Model,Renk,KM,TC,Ehliyet_No,Ehliyet_Tarih,Ad_Soyad,TelNo,VerilisTarih,VerilisSaat,GunSayısı,GunlukUcret,VerilisYeri) Values(@PLaka,@Marka,@Model,@Renk,@KM,@TC,@Ehliyet_No,@Ehliyet_Tarih,@Ad_Soyad,@TelNo,@VerilisTarih,@VerilisSaat,@GunSayısı,@GunlukUcret,@VerilisYeri)";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            komut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
            komut.Parameters.AddWithValue("@Marka", txtMarka.Text);
            komut.Parameters.AddWithValue("@Model", txtModel.Text);
            komut.Parameters.AddWithValue("@Renk", txtRenk.Text);
            komut.Parameters.AddWithValue("@KM", txtKm.Text);
            komut.Parameters.AddWithValue("@TC", txtTcNo.Text);
            komut.Parameters.AddWithValue("@Ehliyet_No", txtEhliyetno.Text);
            komut.Parameters.AddWithValue("@Ehliyet_Tarih", txtth.Text);
            komut.Parameters.AddWithValue("@Ad_Soyad", txtAdSoy.Text);
            komut.Parameters.AddWithValue("@TelNo", txtTel.Text);
            komut.Parameters.AddWithValue("@VerilisTarih", txtTarih.Text);
            komut.Parameters.AddWithValue("@VerilisSaat", txtSaat.Text);
            komut.Parameters.AddWithValue("@GunSayısı", txtgun.Text);
            komut.Parameters.AddWithValue("@GunlukUcret", txtucret.Text);
            komut.Parameters.AddWithValue("@VerilisYeri", txtYer.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtPlaka.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtRenk.Text = "";
            txtKm.Text = "";
            txtTcNo.Text = "";
            txtEhliyetno.Text = "";
            txtth.Text = "";
            txtAdSoy.Text = "";
            txtTel.Text = "";
            txtTarih.Text = "";
            txtSaat.Text = "";
            txtgun.Text = "";
            txtucret.Text = "";
            txtYer.Text = "";
            MessageBox.Show("Sözlesme Eklendi");
         
        }
    }
}

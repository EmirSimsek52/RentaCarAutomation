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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RentCarOtomation
{
    public partial class Teslimatlar : Form
    {
        public Teslimatlar()
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
        public void sozlesmeListe()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Select * From tablo3";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaka.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTcNo.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtEhliyetno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtth.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAdSoy.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtSaat.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtgun.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtucret.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtYer.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
        }

        private void Teslimatlar_Load(object sender, EventArgs e)
        {
            sozlesmeListe();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Delete From tablo3 where Plaka='" + dataGridView1.CurrentRow.Cells["Plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            sozlesmeListe();
            MessageBox.Show("Kayit Silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutcumlesi = "Update tablo3 set PLaka=@Plaka,Marka=@Marka,Model=@Model,Renk=@Renk,KM=@KM,TC=@TC,Ehliyet_No=@Ehliyet_No,Ehliyet_Tarih=@Ehliyet_Tarih,Ad_Soyad=@Ad_Soyad,TelNo=@TelNo,VerilisTarih=@VerilisTarih,VerilisSaat=@VerilisSaat,GunSayısı=@GunSayısı,GunlukUcret=@GunlukUcret,VerilisYeri=@VerilisYeri Where PLaka=@Plaka";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
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
            sozlesmeListe();
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
            MessageBox.Show("Teslmat Güncellendi");
        }

        private void txtPlakaAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutcumlesi = "Select * From  tablo3 where Plaka like '" + txtPlakaAra.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txtadARA_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutcumlesi = "Select * From  tablo3 where Ad_Soyad like '" + txtadARA.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void txttcAra_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();

            string komutcumlesi = "Select * From  tablo3 where TC like '" + txttcAra.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}

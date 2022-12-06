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
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }
        private string baglanticumlesi = @"Data Source=.\SQLEXPRESS;Initial Catalog=RentCar;Integrated Security=True";
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }
        public void MusteriListele()
        {
            SqlConnection baglanti= new SqlConnection(baglanticumlesi);
            baglanti.Open();

            string komutcumlesi = "Select * From  tablo1";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da =new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();

            string komutcumlesi = "Update tablo1 set Tc_No=@Tc_No, Ad_Soyad=@Ad_Soyad, Telefon_Numarsu=@Telefon_Numarsu, Mail=@Mail, Adres=@Adres Where Tc_No=@Tc_No";

            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            komut.Parameters.AddWithValue("@Tc_No", txtTc.Text);
            komut.Parameters.AddWithValue("@Ad_Soyad", txtAd.Text);
            komut.Parameters.AddWithValue("@Telefon_Numarsu", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriListele();
            MessageBox.Show("Kayit Güncellendi");
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();
            string komutcumlesi = "Delete From tablo1 where Tc_No='" + dataGridView1.CurrentRow.Cells["Tc_No"].Value.ToString() +"'";
            SqlCommand komut= new SqlCommand(komutcumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriListele();
            MessageBox.Show("Kayit Silindi.");
        }

        private void txtTcara_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();

            string komutcumlesi = "Select * From  tablo1 where Tc_No like '"+txtTcara.Text+"%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}

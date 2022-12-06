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
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        private string baglanticumlesi = @"Data Source=.\SQLEXPRESS;Initial Catalog=RentCar;Integrated Security=True";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AracListe()
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();
            string komutcumlesi = "Select * From tablo2";
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
            txtYil.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtYakit.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKira.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtBakim.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtKm.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void AracListele_Load(object sender, EventArgs e)
        {
            AracListe();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();

            string komutcumlesi = "Select * From  tablo2 where plaka like '" + textBox1.Text + "%'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();
            string komutcumlesi = "Delete From tablo2 where plaka='" + dataGridView1.CurrentRow.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            AracListe();
            MessageBox.Show("Kayit Silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(baglanticumlesi);
            baglanti.Open();

            string komutcumlesi = "Update tablo2 set plaka=@plaka, marka=@marka, model=@model, yıl=@yıl, renk=@renk,yakıt=@yakıt, kira=@kira, bakım=@bakım, bakımkm=@bakımkm,resim=@resim Where plaka=@plaka";
            SqlCommand komut = new SqlCommand(komutcumlesi, baglanti);
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
            AracListe();
            MessageBox.Show("Araç Güncellendi");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

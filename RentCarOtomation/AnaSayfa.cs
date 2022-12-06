using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarOtomation
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 musteriEkle = new Form2();
            musteriEkle.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 musteriEkle = new Form2();
            musteriEkle.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriListele frmMusteriListele = new frmMusteriListele();
            frmMusteriListele.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmMusteriListele frmMusteriListele = new frmMusteriListele();
            frmMusteriListele.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sozlesmeler sozlesmeler = new Sozlesmeler();
            sozlesmeler.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Sozlesmeler sozlesmeler = new Sozlesmeler();
            sozlesmeler.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Teslimatlar teslimatlar = new Teslimatlar();
            teslimatlar.Show();     
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Teslimatlar teslimatlar = new Teslimatlar();
            teslimatlar.Show();
        }
    }
}

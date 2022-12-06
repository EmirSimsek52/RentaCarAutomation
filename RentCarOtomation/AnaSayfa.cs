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

        private void pictureBoxCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 musteriEkle = new Form2();
            musteriEkle.Show();
        }

        private void pictureBoxMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 musteriEkle = new Form2();
            musteriEkle.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMusteriLiset_Click(object sender, EventArgs e)
        {
            frmMusteriListele frmMusteriListele = new frmMusteriListele();
            frmMusteriListele.Show();
        }

        private void pictureBoxMusteriListe_Click(object sender, EventArgs e)
        {
            frmMusteriListele frmMusteriListele = new frmMusteriListele();
            frmMusteriListele.Show();
        }

        private void buttonAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.Show();
        }

        private void pictureBoxAracEkle_Click(object sender, EventArgs e)
        {
            AracEkle aracEkle = new AracEkle();
            aracEkle.Show();
        }

        private void buttonSozlesme_Click(object sender, EventArgs e)
        {
            Sozlesmeler sozlesmeler = new Sozlesmeler();
            sozlesmeler.Show();

        }

        private void pictureBoxAracListe_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.Show();
        }

        private void buttonAracListe_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.Show();
        }

        private void pictureBoxSozlesme_Click(object sender, EventArgs e)
        {
            Sozlesmeler sozlesmeler = new Sozlesmeler();
            sozlesmeler.Show();
        }

        private void buttonTeslimat_Click(object sender, EventArgs e)
        {
            Teslimatlar teslimatlar = new Teslimatlar();
            teslimatlar.Show();     
        }

        private void pictureBoxTeslimat_Click(object sender, EventArgs e)
        {
            Teslimatlar teslimatlar = new Teslimatlar();
            teslimatlar.Show();
        }
    }
}

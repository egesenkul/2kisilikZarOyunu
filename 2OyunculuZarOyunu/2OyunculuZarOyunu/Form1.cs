using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2OyunculuZarOyunu
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int Oyuncu1zarSonDeger=0;
        int Oyuncu2zarSonDeger=0;
        int ResimGosterilmeSayisi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ZarDegistir(int i)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(200);
            switch (i)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.zar1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.zar2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.zar3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.zar4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.zar5;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.zar6;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 2) == 0)
            {
                btnOyuncu1.Visible = true;
                btnOyuncu2.Visible = false;
            }
            else
            {
                btnOyuncu1.Visible = false;
                btnOyuncu2.Visible = true;
            }
        }
        

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Oyuncu1zarSonDeger = rnd.Next(0, 7);
                ZarDegistir(Oyuncu1zarSonDeger);
            }
            btnOyuncu1.Visible = false;
            btnOyuncu2.Visible = true;
            ResimGosterilmeSayisi++;
            if (ResimGosterilmeSayisi % 2 == 0)
            {
                SkorKontrol();
            }
        }

        private void SkorKontrol()
        {
            int skor;
            if (Oyuncu1zarSonDeger > Oyuncu2zarSonDeger)
            {
                skor = Convert.ToInt32(skorOyuncu1.Text);
                skor++;
                skorOyuncu1.Text = skor.ToString();
            }
            else
            {
                skor = Convert.ToInt32(skorOyuncu2.Text);
                skor++;
                skorOyuncu2.Text = skor.ToString();
            }
            Oyuncu1zarSonDeger = 0;
            Oyuncu2zarSonDeger = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Oyuncu2zarSonDeger = rnd.Next(0, 7);
                ZarDegistir(Oyuncu2zarSonDeger);
            }
            btnOyuncu1.Visible = true;
            btnOyuncu2.Visible = false;
            ResimGosterilmeSayisi++;
            if (ResimGosterilmeSayisi % 2 == 0)
            {
                SkorKontrol();
            }
        }
    }
}

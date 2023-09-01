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

namespace Lets_Roll
{
    public partial class Database_islemleri : Form
    {
        public Database_islemleri()
        {
            InitializeComponent();
        }

        KarekterlerContext karaktergetir = new KarekterlerContext();
        int ıd;
        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox5.Text=="")
            {
                MessageBox.Show("lütfen Database Id kutucugunu doldurun");
            }
            else
            {
                ıd = Convert.ToInt32(textBox5.Text);
                var k = karaktergetir.Waifu.Find(ıd);

                textBox1.Text = k.KarekterAdi;
                textBox2.Text = Convert.ToString(k.KarekterRank);
                textBox3.Text = k.SeriAdi;
                textBox4.Text = k.A2text;
                textBox6.Text = k.ResimYolu;
                pictureBox1.ImageLocation = k.ResimYolu;

                MessageBox.Show("Başarı ile getirildi");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ıd = Convert.ToInt32(textBox5.Text);
            var k = karaktergetir.Waifu.Find(ıd);

            k.KarekterAdi = textBox1.Text;
            k.KarekterRank = Convert.ToInt32(textBox2.Text);
            k.SeriAdi = textBox3.Text;
            k.A2text = textBox4.Text;
            k.ResimYolu = textBox6.Text;
            pictureBox1.ImageLocation = k.ResimYolu;

            var g = karaktergetir.SaveChanges();

            if (g != 0)
            {
                MessageBox.Show("Veriler başarıyla güncellendi...!");
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            textBox6.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ıd = Convert.ToInt32(textBox5.Text);
            var k = karaktergetir.Waifu.Find(ıd);
            karaktergetir.Waifu.Remove(k);

            var s = karaktergetir.SaveChanges();

            if (s != 0)
            {
                MessageBox.Show("Veri Silindi...!");
            }

           
        }
    }
}

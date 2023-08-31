using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Roll
{
    public partial class YetkiliAnasayfa : Form
    {
        public YetkiliAnasayfa()
        {
            InitializeComponent();
        }

        private void YetkiliAnasayfa_Load(object sender, EventArgs e)
        {

        }
        string yeniyol;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            textBox5.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;

        }
        KarekterlerContext karakterler = new KarekterlerContext();
        private void button1_Click(object sender, EventArgs e)
        {
            //Checkbox kontrolleri .

            if(WaifuBox.Checked == false && Husband.Checked == false && MixBox.Checked == false)
            {
                MessageBox.Show("Veriyi hangi tabloya eklemek istiyorsunuz _?_");
            }
            else if(WaifuBox.Checked == true && Husband.Checked==true && MixBox.Checked==true)
            {
                MessageBox.Show("Lütfen tek bir tablo seçiniz...!");
            }

            else if (WaifuBox.Checked == true && Husband.Checked == true && MixBox.Checked == false || WaifuBox.Checked == true && Husband.Checked == false && MixBox.Checked == true || WaifuBox.Checked == false && Husband.Checked == true && MixBox.Checked == true)
            {
                MessageBox.Show("Lütfen tek bir tablo seçiniz...!");
            }

            // Seçili check ox a göre ilgili tablolara veri ekleme işlemleri.
            if (WaifuBox.Checked)
            {
                karakterler.Waifu.Add(
                    new Waifu
                    {
                        KarekterAdi = textBox1.Text,
                        KarekterRank = Convert.ToInt32( textBox2.Text),
                        SeriAdi = textBox3.Text,
                        A2text = textBox4.Text,
                        ResimYolu = textBox5.Text,

                    }

                    );
                var k = karakterler.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }
                else
                {
                    MessageBox.Show("Tekrar Deneyiniz", "Uyarı");
                }
            }

           else if (Husband.Checked)
            {
                karakterler.Husband.Add(
                    new Husband
                    {
                        KarekterAdi = textBox1.Text,
                        KarekterRank = Convert.ToInt32(textBox2.Text),
                        SeriAdi = textBox3.Text,
                        A2text = textBox4.Text,
                        ResimYolu = textBox5.Text,

                    }

                    );
                var k = karakterler.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }
            }


            else if (MixBox.Checked)
            {
                karakterler.MixTablosu.Add(
                    new MixTablosu
                    {
                        KarekterAdi = textBox1.Text,
                        KarekterRank = Convert.ToInt32(textBox2.Text),
                        SeriAdi = textBox3.Text,
                        A2text = textBox4.Text,
                        ResimYolu = textBox5.Text,

                    }

                    );
                var k = karakterler.SaveChanges();

                if (k != 0)
                {
                    MessageBox.Show("Başarıyla Kaydedildi", "Uyarı");
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }
    }
}

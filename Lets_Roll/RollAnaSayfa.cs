﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lets_Roll
{
    public partial class RollAnaSayfa : Form
    {
        public RollAnaSayfa()
        {
            InitializeComponent();
        }
        public string SeciliBox()
        {
            if(checkBox1.Checked)
            {
                return "waifu";
            }
            else if(checkBox2.Checked)
            {
                return "husband";
            }
            else if(checkBox3.Checked)
            {
                return "Waifu / Husband";
            }
            return Convert.ToString( MessageBox.Show("Seçim Yapınız"));
        }

        public int random()
        {
            int eleman = 1;
            int eleman1 = 2;
            Random a = new Random();
            int random = a.Next(2, 29);
            List<int> listNumbers = new List<int>();
            
            listNumbers.Add(eleman);
            listNumbers.Add(eleman1);

            textBox8.Text = Convert.ToString(random);

            for (int i=0 ; i<=listNumbers.Count; i++)
            {
                if(random == listNumbers[i])
                {
                    random = a.Next(2, 29);
                    textBox9.Text = Convert.ToString(random);

                }
                else
                {
                    listNumbers.Add(random);
                    textBox10.Text = Convert.ToString(random);
                    return random;
                }

            }
            listNumbers.Clear();
            return 0;


            /*
                        Random a = new Random();
                        int random = a.Next(1, 29);
                        textBox8.Text = Convert.ToString(random);

                        random = a.Next(1, 29);
                        textBox9.Text = Convert.ToString(random);

                        string strrandom = Convert.ToString(random);
                        textBox10.Text = strrandom;


                        if (strrandom == textBox8.Text)
                        {
                            random = a.Next(1, 29);
                            textBox11.Text = Convert.ToString(random);
                            return random;

                        }

                        return random;


            */
        }


        int i = 5;
        KarekterlerContext karekterler1 = new KarekterlerContext();
        KarekterlerContext date = new KarekterlerContext();
   
        private void RollButonu_Click(object sender, EventArgs e)
        {
             timer1.Enabled = true;
             timer2.Enabled = true;
            

            // Sadece 1 defalıgına saat tutacagız veritabanında
            DateTime globalSaat = DateTime.UtcNow;
            TimeSpan saat = globalSaat.TimeOfDay;
            string bayrakDosyasi = "bayrak.txt2";

            if (!File.Exists(bayrakDosyasi))
            {
                date.DateSayac.Add
                  (

                  new DateSayac
                  {
                      Date = saat,
                  }

                  );
                var k = date.SaveChanges();

                if (k != 0)
                {
                    textBox12.Text = Convert.ToString(globalSaat);
                    MessageBox.Show("Kaydedildi");
                }
                

                // Bayrak dosyasını oluştur
                File.Create(bayrakDosyasi);
            }


            var d = date.DateSayac.Find(2);

            textBox12.Text = Convert.ToString(d.Date);

            DateTime tarih = DateTime.UtcNow;
            TimeSpan saat2 = tarih.TimeOfDay;

            TimeSpan sayacsaat = saat2 - saat;

            textBox13.Text = Convert.ToString(sayacsaat);


            // Saat tutma kodu bitti

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && i>0)
            {
                MessageBox.Show("Lütfen roll atmak istediğiniz türü seçiniz...!");

            }

            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && i>0 
            || checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && i>0
            || checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && i>0
            || checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true  && i>0)
            {
                MessageBox.Show("Lütfen roll atmak için tek bir tür seçiniz...!");

            }

            else
            {

                if (checkBox1.Checked && i == 5)
                {
                    var k = karekterler1.Waifu.Find(random());
                    listBox1.Items.Add(k.KarekterAdi);
                    listBox1.Items.Add(k.KarekterRank);
                    listBox1.Items.Add(k.SeriAdi);
                    listBox1.Items.Add(k.A2text);
                    pictureBox1.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);


                }


                else if (checkBox1.Checked && i == 4)
                {
                    var k = karekterler1.Waifu.Find(random());
          
                    listBox2.Items.Add(k.KarekterAdi);
                    listBox2.Items.Add(k.KarekterRank);
                    listBox2.Items.Add(k.SeriAdi);
                    listBox2.Items.Add(k.A2text);
                    pictureBox2.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (checkBox1.Checked && i == 3)
                {
                    var k = karekterler1.Waifu.Find(random());
                    listBox3.Items.Add(k.KarekterAdi);
                    listBox3.Items.Add(k.KarekterRank);
                    listBox3.Items.Add(k.SeriAdi);
                    listBox3.Items.Add(k.A2text);
                    pictureBox3.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (checkBox1.Checked && i == 2)
                {
                    var k = karekterler1.Waifu.Find(random());
                    listBox4.Items.Add(k.KarekterAdi);
                    listBox4.Items.Add(k.KarekterRank);
                    listBox4.Items.Add(k.SeriAdi);
                    listBox4.Items.Add(k.A2text);
                    pictureBox4.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (checkBox1.Checked && i == 1)
                {
                    var k = karekterler1.Waifu.Find(random());
                    listBox5.Items.Add(k.KarekterAdi);
                    listBox5.Items.Add(k.KarekterRank);
                    listBox5.Items.Add(k.SeriAdi);
                    listBox5.Items.Add(k.A2text);
                    pictureBox5.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }



                // Checkboxx 2 için roll seçimi


                if (checkBox2.Checked && i == 5)
                {
                    var k = karekterler1.Husband.Find(random());
                    listBox1.Items.Add(k.KarekterAdi);
                    listBox1.Items.Add(k.KarekterRank);
                    listBox1.Items.Add(k.SeriAdi);
                    listBox1.Items.Add(k.A2text);
                    pictureBox1.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);


                }


                else if (checkBox2.Checked && i == 4)
                {
                    var k = karekterler1.Husband.Find(random());
                    listBox2.Items.Add(k.KarekterAdi);
                    listBox2.Items.Add(k.KarekterRank);
                    listBox2.Items.Add(k.SeriAdi);
                    listBox2.Items.Add(k.A2text);
                    pictureBox2.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (checkBox2.Checked && i == 3)
                {
                    var k = karekterler1.Husband.Find(random());
                    listBox3.Items.Add(k.KarekterAdi);
                    listBox3.Items.Add(k.KarekterRank);
                    listBox3.Items.Add(k.SeriAdi);
                    listBox3.Items.Add(k.A2text);
                    pictureBox3.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (checkBox2.Checked && i == 2)
                {
                    var k = karekterler1.Husband.Find(random());
                    listBox4.Items.Add(k.KarekterAdi);
                    listBox4.Items.Add(k.KarekterRank);
                    listBox4.Items.Add(k.SeriAdi);
                    listBox4.Items.Add(k.A2text);
                    pictureBox4.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (checkBox2.Checked && i == 1)
                {
                    var k = karekterler1.Husband.Find(random());
                    listBox5.Items.Add(k.KarekterAdi);
                    listBox5.Items.Add(k.KarekterRank);
                    listBox5.Items.Add(k.SeriAdi);
                    listBox5.Items.Add(k.A2text);
                    pictureBox5.ImageLocation = k.ResimYolu;
                    i--;
                    textBox5.Text = Convert.ToString(i);

                }

                else if (i==0)
                {
                    MessageBox.Show("Roll Hakkınız Bitti");
                }

            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        int claimhakkı =1 ;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(claimhakkı);

            if(textBox6.Text=="0" && textBox3.Text=="")
            {
                MessageBox.Show("Geçti Bolu pazarı Sür eşeği niğdeye, Zaman Doldu");
            }
            else
            {
                if (textBox1.Text == "1")
                {
                    int listIndex1 = listBox1.SelectedIndex;
                    int listIndex2 = listBox2.SelectedIndex;
                    int listIndex3 = listBox3.SelectedIndex;
                    int listIndex4 = listBox4.SelectedIndex;
                    int listIndex5 = listBox5.SelectedIndex;

                    if (listBox1.SelectedIndex != -1)
                    {
                        // Karekteri al dedikten sonra listbox ve picturboxların içini sıfırlıyoruz.
                        textBox3.Text = listBox1.Items[listIndex1].ToString();
                        textBox4.Text = "Sukuna?";
                        textBox1.Text = "0";
                        claimhakkı--;

                        listBox2.Items.Clear();
                        listBox3.Items.Clear();
                        listBox4.Items.Clear();
                        listBox5.Items.Clear();


                        pictureBox2.ImageLocation = "";
                        pictureBox3.ImageLocation = "";
                        pictureBox4.ImageLocation = "";
                        pictureBox5.ImageLocation = "";

                    }

                    if (listBox2.SelectedIndex != -1)
                    {
                        textBox3.Text = listBox2.Items[listIndex2].ToString();
                        textBox4.Text = "Sukuna?";
                        textBox1.Text = "0";
                        claimhakkı--;

                        listBox1.Items.Clear();

                        listBox3.Items.Clear();
                        listBox4.Items.Clear();
                        listBox5.Items.Clear();

                        pictureBox1.ImageLocation = "";

                        pictureBox3.ImageLocation = "";
                        pictureBox4.ImageLocation = "";
                        pictureBox5.ImageLocation = "";

                    }

                    if (listBox3.SelectedIndex != -1)
                    {
                        textBox3.Text = listBox3.Items[listIndex3].ToString();
                        textBox4.Text = "Sukuna?";
                        textBox1.Text = "0";
                        claimhakkı--;

                        listBox1.Items.Clear();
                        listBox2.Items.Clear();

                        listBox4.Items.Clear();
                        listBox5.Items.Clear();

                        pictureBox1.ImageLocation = "";
                        pictureBox2.ImageLocation = "";

                        pictureBox4.ImageLocation = "";
                        pictureBox5.ImageLocation = "";

                    }

                    if (listBox4.SelectedIndex != -1)
                    {
                        textBox3.Text = listBox4.Items[listIndex4].ToString();
                        textBox4.Text = "Sukuna?";
                        textBox1.Text = "0";
                        claimhakkı--;

                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        listBox3.Items.Clear();

                        listBox5.Items.Clear();

                        pictureBox1.ImageLocation = "";
                        pictureBox2.ImageLocation = "";
                        pictureBox3.ImageLocation = "";

                        pictureBox5.ImageLocation = "";

                    }

                    if (listBox5.SelectedIndex != -1)
                    {
                        textBox3.Text = listBox5.Items[listIndex5].ToString();
                        textBox4.Text = "Sukuna?";
                        textBox1.Text = "0";
                        claimhakkı--;

                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        listBox3.Items.Clear();
                        listBox4.Items.Clear();


                        pictureBox1.ImageLocation = "";
                        pictureBox2.ImageLocation = "";
                        pictureBox3.ImageLocation = "";
                        pictureBox4.ImageLocation = "";


                    }

                }
                else
                {
                    MessageBox.Show("Claim hakkınıza kalan süre.."+sayac2);
                }

            }
            

            
        }

        private void RollAnaSayfa_Load(object sender, EventArgs e)
        {

        }
        int sayac = 30;
        int sayac2 = 60;
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            
                textBox7.Text = Convert.ToString(sayac2);
                sayac2--;
                

                textBox2.Text = Convert.ToString(sayac);
                sayac--;

                if (sayac == 0)
                {
                    sayac = 30;
                    textBox2.Text = "30";
                    textBox5.Text = " 5";
                    i = 5;
                    karektersayac = 15;
                    textBox6.Text = "15";
                   
                   
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    listBox4.Items.Clear();
                    listBox5.Items.Clear();
                    pictureBox1.ImageLocation = "";
                    pictureBox2.ImageLocation = "";
                    pictureBox3.ImageLocation = "";
                    pictureBox4.ImageLocation = "";
                    pictureBox5.ImageLocation = "";
                   
                }
                if(sayac2 == 0)
                {
                    textBox7.Text = "60";
                    sayac2 = 60;
                    textBox1.Text = "1";
                    claimhakkı=1;
                    textBox3.Text = "";
                    textBox4.Text = "";
                }

            
            

        }

        int karektersayac = 15;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && i==5)
            {
                timer2.Enabled = false;

            }

            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false && i == 5
            || checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true && i == 5
            || checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true && i == 5
            || checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && i == 5)
            {
                timer2.Enabled = false;
            }

            else
            {
                textBox6.Text = Convert.ToString(karektersayac);

                if (karektersayac != 0 && i!=5)
                {
                    karektersayac--;

                }
               

            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        int i = 5;
        KarekterlerContext karekterler1 = new KarekterlerContext();
        private void RollButonu_Click(object sender, EventArgs e)
        {
            Random a = new Random();
            int random = a.Next(2,6);

            


            if (checkBox1.Checked &&  i == 5)
            {
                var k = karekterler1.Waifu.Find(random);
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
                var k = karekterler1.Waifu.Find(random);
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
                var k = karekterler1.Waifu.Find(random);
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
                var k = karekterler1.Waifu.Find(random);
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
                var k = karekterler1.Waifu.Find(random);
                listBox5.Items.Add(k.KarekterAdi);
                listBox5.Items.Add(k.KarekterRank);
                listBox5.Items.Add(k.SeriAdi);
                listBox5.Items.Add(k.A2text);
                pictureBox5.ImageLocation = k.ResimYolu;
                i--;
                textBox5.Text = Convert.ToString(i);

            }
            else
            {
                MessageBox.Show("Roll Hakkınız Bitti");
            }
                    

            

            







        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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

            if (listBox2.SelectedIndex != -1)
            {
                textBox3.Text = listBox2.Items[listIndex2].ToString();
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

            if (listBox3.SelectedIndex != -1 )
            {
                textBox3.Text = listBox3.Items[listIndex3].ToString();
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

            if (listBox4.SelectedIndex != -1 )
            {
                textBox3.Text = listBox4.Items[listIndex4].ToString();
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

            if (listBox5.SelectedIndex != -1)
            {
                textBox3.Text = listBox5.Items[listIndex5].ToString();
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

            




        }
    }
}

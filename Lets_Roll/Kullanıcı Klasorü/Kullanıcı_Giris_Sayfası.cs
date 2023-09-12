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
    public partial class Kullanıcı_Giris_Sayfası : Form
    {
        public Kullanıcı_Giris_Sayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Lets_Roll.Kullanıcı_Klasorü.KullanıcıAnasayfa kullanıcısayfa = new Lets_Roll.Kullanıcı_Klasorü.KullanıcıAnasayfa();
            kullanıcısayfa.Show();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            Lets_Roll.Kullanıcı_Kaydol kullanıcıkayıt = new Lets_Roll.Kullanıcı_Kaydol();
            kullanıcıkayıt.Show();
          

        }

        private void Kullanıcı_Giris_Sayfası_Load(object sender, EventArgs e)
        {
            
        }
    }
}

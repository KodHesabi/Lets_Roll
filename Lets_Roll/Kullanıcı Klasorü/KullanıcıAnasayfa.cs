using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Roll.Kullanıcı_Klasorü
{
    public partial class KullanıcıAnasayfa : Form
    {
        public KullanıcıAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lets_Roll.Kullanıcı_Giris_Sayfası kapat = new Lets_Roll.Kullanıcı_Giris_Sayfası();
            kapat.Close();

            Lets_Roll.RollAnaSayfa rollanasayfa = new Lets_Roll.RollAnaSayfa();
            rollanasayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lets_Roll.Harem_İşlemleri haremislemleri = new Lets_Roll.Harem_İşlemleri();
            haremislemleri.Show();
        }

        private void KullanıcıAnasayfa_Load(object sender, EventArgs e)
        {
          
        }
    }
}

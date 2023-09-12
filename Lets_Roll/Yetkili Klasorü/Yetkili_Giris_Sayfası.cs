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
    public partial class Yetkili_Giris_Sayfası : Form
    {
        public Yetkili_Giris_Sayfası()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lets_Roll.YetkiliAnasayfa yetkilianasayfa = new Lets_Roll.YetkiliAnasayfa();
            yetkilianasayfa.Show();

          
        }
    }
}

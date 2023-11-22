using System;
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
    public partial class GirisSayfası : Form
    {
        public GirisSayfası()
        {
            InitializeComponent();
        }
      
        private void rolleyelimbutonu_Click(object sender, EventArgs e)
        {
            Lets_Roll.Kullanıcı_Giris_Sayfası kullanıcıgiris = new Lets_Roll.Kullanıcı_Giris_Sayfası();
            kullanıcıgiris.Show();
           
        }

        private void yetkiligirisibutonu_Click(object sender, EventArgs e)
        {
            Lets_Roll.Yetkili_Giris_Sayfası ytklgiris = new Lets_Roll.Yetkili_Giris_Sayfası();
            ytklgiris.Show();
        }

        
        private void GirisSayfası_Load(object sender, EventArgs e)
        {
            
          
              

        }
    }
}

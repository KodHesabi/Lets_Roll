﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lets_Roll
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Database_islemleri());


            //Application.Run(new RollAnaSayfa());

            //Application.Run(new Kullanıcı_Klasorü.KullanıcıAnasayfa());


            //Application.Run(new YetkiliAnasayfa());

            // Application.Run(new GirisSayfası());

            //Application.Run(new Yetkili_Giris_Sayfası());


        }
    }
}

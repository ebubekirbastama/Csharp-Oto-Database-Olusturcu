using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp_Oto_Database_Oluşturcu
{
    public partial class iletisim : MetroForm
    {
        public iletisim()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.ebubekirbastama.com");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/user/Yazilimegitim");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://twitter.com/ebastama");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://github.com/ebubekirbastama");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.facebook.com/ebubekirbastama");
        }



    }
}

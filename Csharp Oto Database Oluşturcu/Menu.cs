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
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Tablo_Olusturma to = new Tablo_Olusturma();
            to.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            baglanti.Tablo("select name from sys.databases ",metroGrid1 );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            iletisim i = new iletisim();
            i.ShowDialog();
        }
    }
}

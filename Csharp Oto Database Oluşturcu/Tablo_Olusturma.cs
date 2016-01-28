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
    public partial class Tablo_Olusturma : MetroForm
    {
        public Tablo_Olusturma()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            baglanti.table_create(metroTextBox1.Text,metroGrid1 .CurrentRow .Cells [0].Value .ToString ());
        }

        private void Tablo_Olusturma_Load(object sender, EventArgs e)
        {
            baglanti.Tablo("select name from sys.databases ", metroGrid1);
        }
    }
}

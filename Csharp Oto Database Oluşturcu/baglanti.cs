using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp_Oto_Database_Oluşturcu
{
    class baglanti
    {
        public static string yol = @"C:\ayar.txt";
        static string server_name;
        StreamReader sr;
        public void ayr()
        {

            sr = File.OpenText(yol);
            //s = sr.ReadLine();
            //datababes_ismi = s;
            sr.Close();
        }
        public static SqlConnection baglantim()
        {
            //ebubekirbastama
            SqlConnection con = new SqlConnection(@"Server=" + server_name + "; Integrated Security=true;");

            if (con.State == ConnectionState.Closed) // System.Data.SqlClient.ConnectionState using System.Data; kütüphanesinden gelir
            {
                con.Open();
            }
            return con;
        }
        public static SqlConnection baglantimi(string datababes_ismi)
        {
            SqlConnection con = new SqlConnection(@"Server=" + server_name + "; Integrated Security=true; Database=" + datababes_ismi + "");
                //ebubekirbastama
                if (con.State == ConnectionState.Closed) // System.Data.SqlClient.ConnectionState using System.Data; kütüphanesinden gelir
                {
                    con.Open();
                }
                return con;
        }
        public static void database_create(string sqlcümle)
        {
            try
            {
                SqlConnection con = baglantim();
                SqlCommand kmt = new SqlCommand(sqlcümle, con);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Database oluşturuldu.","Ebubekir Bastama.com");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ebubekir Bastama.com");
            }
        }
        public static void table_create(string sqlcümle, string datababes_ismi)
        {
            try
            {
                SqlConnection con = baglantimi(datababes_ismi);
                SqlCommand kmt = new SqlCommand(sqlcümle, con);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Tablo oluşturuldu.", "Ebubekir Bastama.com");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ebubekir Bastama.com");
            }
        }
        public static void temizle(MetroGrid grid)
        {
            foreach (DataGridViewCell oneCell in grid.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    grid.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }
        public static DataTable Tablo(string sqlCumlem, DataGridView veridatagrid)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sqlCumlem, baglantim());
           DataTable dt = new DataTable();
            try
            {
                baglantim();
                adap.Fill(dt);
                veridatagrid.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ebubekir Otomasyon");
            }
            adap.Dispose();
            return dt;
        }
    }
}

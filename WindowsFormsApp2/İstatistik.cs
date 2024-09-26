using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class İstatistik : Form
    {
        public İstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EGE;Initial Catalog=Personel_Database;Integrated Security=True;TrustServerCertificate=True");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void İstatistik_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) from PerTable1 ", baglan);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                label4.Text = dr1[0].ToString(); //Gelen sonucun 1. Kolonunun verisini label4'e yazdır.
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("select Count(*) from PerTable1 where PerDurum ='1'", baglan);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                label5.Text = dr2[0].ToString();
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from PerTable1 where PerDurum = '0'", baglan);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                label6.Text = dr3[0].ToString();
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut4 = new SqlCommand("select count(DISTINCT PerSehir) from PerTable1", baglan);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                label7.Text = dr4[0].ToString();
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut5 = new SqlCommand("select sum(PerMaaş) from PerTable1", baglan);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                label9.Text = dr5[0].ToString();
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut6 = new SqlCommand("select avg(PerMaaş) from PerTable1", baglan);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read()) {
                label11.Text = dr6[0].ToString();
            }
            baglan.Close();
        }
    }
}

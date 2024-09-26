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
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EGE;Initial Catalog=Personel_Database;Integrated Security=True;TrustServerCertificate=True");

        private void Grafik_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand g1 = new SqlCommand("Select PerSehir,Count(*) From PerTable1 group by PerSehir", baglan);
            SqlDataReader dr1 = g1.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]); // Her çalıştığında yeni kolon ekler
            }
            baglan.Close();
            baglan.Open();
            SqlCommand g2 = new SqlCommand("Select PerMeslek,AVG(PerMaaş) From PerTable1 group by PerMeslek ", baglan);
            SqlDataReader dr2 = g2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek - Maas"].Points.AddXY(dr2[0], dr2[1]); // Her çalıştığında yeni kolon ekler
            } 
            baglan.Close();
        }
    }
}

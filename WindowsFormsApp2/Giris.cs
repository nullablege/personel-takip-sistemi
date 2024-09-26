using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
        SqlConnection baglan = new SqlConnection("Data Source=EGE;Initial Catalog=Personel_Database;Integrated Security=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string aranacak = textBox1.Text;
            string sifre = textBox2.Text;
            SqlCommand kullanici = new SqlCommand("select * from admin",baglan);
            SqlDataReader dr1 = kullanici.ExecuteReader();
            int kontrol = 0;
            while (dr1.Read())
            {
                if(Convert.ToBoolean((Convert.ToString(dr1[1]) == sifre)) && Convert.ToBoolean((Convert.ToString(dr1[0]) == aranacak)))
                {
                    this.Hide();
                    AnaForm ana = new AnaForm();
                    ana.Show();
                    kontrol++;
                }
            }
            if(kontrol!= 1)
            {
                MessageBox.Show("Hata !!");
            }
            baglan.Close();
        }
    }
}

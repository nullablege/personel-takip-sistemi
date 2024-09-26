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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=EGE;Initial Catalog=Personel_Database;Integrated Security=True;TrustServerCertificate=True");

        void temizle()
        {
            perid.Text = "";
            perad.Text = "";
            soyad.Text = "";
            sehir.Text = "";
            maas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            meslek.Text = "";
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_DatabaseDataSet.PerTable1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.perTable1TableAdapter.Fill(this.personel_DatabaseDataSet.PerTable1);
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into PerTable1(PerAd,PerSoyad,PerSehir,PerMaaş,PerDurum,PerMeslek) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglan);
            komut.Parameters.AddWithValue("@p1", perad.Text);
            komut.Parameters.AddWithValue("@p2", soyad.Text);
            komut.Parameters.AddWithValue("@p3", sehir.Text);
            komut.Parameters.AddWithValue("@p4", maas.Text);
            komut.Parameters.AddWithValue("@p5", label1.Text);
            komut.Parameters.AddWithValue("@p6", meslek.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            temizle();
            this.perTable1TableAdapter.Fill(this.personel_DatabaseDataSet.PerTable1);
            MessageBox.Show("Kaydetme işlemi başarılı.");
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "True";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "False";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Hangi satır seçildi
            perid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            perad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string durum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if (Convert.ToBoolean(durum))
            {
                radioButton1.Checked = true;
            } 
            else
            {
                radioButton2.Checked = false;
            }
            meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            int silinecek = Convert.ToInt32(perid.Text);
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from PerTable1 where Perid = @p1", baglan);
            komut.Parameters.AddWithValue("@p1", silinecek);
            komut.ExecuteNonQuery();
            baglan.Close();
            this.perTable1TableAdapter.Fill(this.personel_DatabaseDataSet.PerTable1);
            MessageBox.Show("Silme işlemi başarılı.");
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            int guncellenecek = Convert.ToInt32(perid.Text);
            baglan.Open();
            SqlCommand komut = new SqlCommand("update PerTable1 Set PerAd=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaaş=@p4,PerMeslek=@p6 where Perid = @p5 ", baglan);
            komut.Parameters.AddWithValue("@p1", perad.Text);
            komut.Parameters.AddWithValue("@p2", soyad.Text);
            komut.Parameters.AddWithValue("@p3", sehir.Text);
            komut.Parameters.AddWithValue("@p4", maas.Text);
            komut.Parameters.AddWithValue("@p5", guncellenecek);
            if (Convert.ToBoolean(label1.Text))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            komut.Parameters.AddWithValue("@p6", meslek.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            temizle();
            this.perTable1TableAdapter.Fill(this.personel_DatabaseDataSet.PerTable1);
            MessageBox.Show("Güncelleme işlemi başarılı.");
        }

        private void istatistikbtn_Click(object sender, EventArgs e)
        {
            İstatistik ista = new İstatistik();
            ista.Show();

        }

        private void grafikbtn_Click(object sender, EventArgs e)
        {
            Grafik gr = new Grafik();
            gr.Show();
        }
    }
}

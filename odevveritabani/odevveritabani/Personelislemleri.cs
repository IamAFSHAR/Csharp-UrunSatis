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

namespace odevveritabani
{
    public partial class Personelislemleri : Form
    {
        public Personelislemleri()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-G1V2PQJ;Initial Catalog=UrunSatis;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
                conn.Open();
                SqlCommand cmd = new SqlCommand("ekleme", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("SİcilNo", int.Parse(txtsicilno.Text));
                cmd.Parameters.AddWithValue("Tc", txttcno.Text);
                cmd.Parameters.AddWithValue("Ad", txtad.Text);
                cmd.Parameters.AddWithValue("Soyad", txtsoyad.Text);
                cmd.Parameters.AddWithValue("PersonelTipi", int.Parse(txtpertip.Text));
                cmd.Parameters.AddWithValue("Telefon", txttel.Text);
                cmd.Parameters.AddWithValue("Prim", decimal.Parse(txtPrim.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("EKLEME TAMAMLANDI");

                
                

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Personelislemleri_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sil = new SqlCommand("personelsil", conn);
            sil.CommandType = CommandType.StoredProcedure;
            sil.Parameters.AddWithValue("SİcilNo", int.Parse(txtsicilsil.Text));
            sil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");

            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand güncelle = new SqlCommand("updatepersonel", conn);
            güncelle.CommandType = CommandType.StoredProcedure;
            güncelle.Parameters.AddWithValue("SİcilNo", int.Parse(txtsicilno.Text));
            güncelle.Parameters.AddWithValue("Tc", txttcno.Text);
            güncelle.Parameters.AddWithValue("Ad", txtad.Text);
            güncelle.Parameters.AddWithValue("Soyad", txtsoyad.Text);
            güncelle.Parameters.AddWithValue("PersonelTipi", int.Parse(txtpertip.Text));
            güncelle.Parameters.AddWithValue("Telefon", txttel.Text);
            güncelle.Parameters.AddWithValue("Prim", decimal.Parse(txtPrim.Text));
            güncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncelleme Gerçekleşti");
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();

        }
    }
}

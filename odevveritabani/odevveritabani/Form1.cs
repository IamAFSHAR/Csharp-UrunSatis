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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cabbar(string a)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1V2PQJ;Initial Catalog=UrunSatis;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(a, baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                cabbar("PersonelTipi");
            }
            else if (radioButton3.Checked == true)
            {
                cabbar("BolgeTablosu");
            }
            else if (radioButton2.Checked == true)
            {
                cabbar("adres_goster");
            }

            else if (radioButton1.Checked == true)
            {
                cabbar("personel_listele");
            }
            else if (radioButton5.Checked==true)
            {
                cabbar("PerTIP_PerSAYI");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cabbar("personel_listele");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personelislemleri islem = new Personelislemleri();
            islem.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}

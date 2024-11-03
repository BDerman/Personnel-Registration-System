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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ödev___2
{
    public partial class PersonelGirisSistemi : Form
    {


        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public PersonelGirisSistemi()
        {
            InitializeComponent();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var PersonelKayitSistemi = new PersonelKayitSistemi();
            PersonelKayitSistemi.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var PersonelKayit = new PersonelKayit();
            PersonelKayit.Show();

            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String PersonelKimlikNo = textBox1.Text;

            con = new SqlConnection("Data Source=THERMAN\\SQLEXPRESS; Initial Catalog=Personeller; Integrated Security=true");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From PersonelSifreleri Where Personel_Sifre = '" + textBox2.Text +"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {

                var PersonelBilgiSistemi = new PersonelBilgiSistemi();
                PersonelBilgiSistemi.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Bu Personel Geçersiz Lütfen Kontrol Edin", "Kontrol Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                textBox2.PasswordChar = '*'; // Şifreyi Gizle
            }
            else
            {
                textBox2.PasswordChar = '\0'; // Şifreyi Göster
            }
        }
    }
}

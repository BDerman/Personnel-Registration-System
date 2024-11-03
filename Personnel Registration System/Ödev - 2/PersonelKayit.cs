using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ödev___2
{
    public partial class PersonelKayit : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        private SqlConnection Baglanti = new SqlConnection("Data Source=THERMAN\\SQLEXPRESS; Initial Catalog=Personeller; Integrated Security=true");

        public void KayitEkle()
        {
            Baglanti.Open();
            String Kayit = "Insert Into PersonelSifreleri (Personel_Sifre) Values (@Personel_Sifre)";
            SqlCommand Ekle = new SqlCommand(Kayit, Baglanti);
            Ekle.Parameters.AddWithValue("@Personel_Sifre", textBox4.Text);
            Ekle.ExecuteNonQuery();
            Baglanti.Close();
        }

        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.PasswordChar == '\0')
            {
                textBox4.PasswordChar = '*'; // Şifreyi Gizle
            }
            else
            {
                textBox4.PasswordChar = '\0'; // Şifreyi Göster
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PersonelGirisSistemi = new PersonelGirisSistemi();
            PersonelGirisSistemi.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String PersonelAdi = textBox3.Text;
            String PersonelSoyadi = textBox2.Text;
            String PersoelKimlikNo = textBox1.Text;

            con = new SqlConnection("Data Source=THERMAN\\SQLEXPRESS; Initial Catalog=Personeller; Integrated Security=true");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From PersonelBilgileri Where Personel_Adi = '" + textBox3.Text +
                "'And Personel_Soyadi = '" + textBox2.Text + "'And Personel_Kimlik_Numarasi = '" + textBox1.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {

                KayitEkle();

                MessageBox.Show("Kaydınız Tamamlandı Siteme Giriş Yapabilirsiniz", "Kontrol Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Bu Personel Sisteme Kayıtlı Değil", "Kontrol Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();

        }
    }
}

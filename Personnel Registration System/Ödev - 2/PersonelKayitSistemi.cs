using System.Globalization;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ödev___2
{

    public partial class PersonelKayitSistemi : Form
    {
        Image File;
        private string ResimYolu;


        private SqlConnection Baglanti = new SqlConnection("Data Source=THERMAN\\SQLEXPRESS; Initial Catalog=Personeller; Integrated Security=true");

        public void KayitEkle()
        {
            Baglanti.Open();
            String Kayit = "Insert Into PersonelBilgileri (Personel_Adi, Personel_Soyadi, Personel_Kimlik_Numarasi) Values (@Personel_Adi, @Personel_Soyadi, @Personel_Kimlik_Numarasi)";
            SqlCommand Ekle = new SqlCommand(Kayit, Baglanti);
            Ekle.Parameters.AddWithValue("@Personel_Adi", textBox1.Text);
            Ekle.Parameters.AddWithValue("@Personel_Soyadi", textBox2.Text);
            Ekle.Parameters.AddWithValue("@Personel_Kimlik_Numarasi", maskedTextBox2.Text);
            Ekle.ExecuteNonQuery();
            Baglanti.Close();

        }
        public PersonelKayitSistemi()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            String Cinsiyet = radioButton1.Checked ? "Erkek" : "Kadın";

            DialogResult MesajSonuc = MessageBox.Show("Personeli Kaydetmek İstiyormusun", "Kayıt Uyarı Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MesajSonuc == DialogResult.Yes)
            {
                PersonelList.Items.Add("Personel Kişisel Bilgileri : " + textBox1.Text + "  |==|  " + textBox2.Text + "  |==|  " + textBox3.Text + "  |==|  " + Cinsiyet + "  |==|  " + maskedTextBox1.Text + "  |==|  " + comboBox1.Text + "  |==|  " + maskedTextBox2.Text + "  |==|  " + comboBox2.Text + "  |==|  " + textBox4.Text + "  |==|  " + textBox5.Text + "  |==|  " + comboBox3.Text + "  |==|  " + comboBox4.Text + "  |==|  " + comboBox5.Text + "  |==|  " + textBox6.Text);
                PersonelList.Items.Add("Personel İş Bilgileri : " + textBox7.Text + "  |==|  " + comboBox6.Text + "  |==|  " + maskedTextBox3.Text + "  |==|  " + comboBox8.Text + "  |==|  " + comboBox7.Text + "  |==|  " + textBox9.Text + "  |==|  " + textBox10.Text);
                PersonelList.Items.Add("Personel Açıklaması : " + textBox11.Text);

                if (!string.IsNullOrEmpty(ResimYolu))
                {
                    PersonelList.Items.Add("Yüklenen Resmin Yolu : " + ResimYolu);
                }

                PersonelList.Items.Add("—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————");

                MessageBox.Show("Personel Kayıt İşlemi Tamamlandı, Personel Şifresi Alarak Sisteme Giriş Yapabilirsin", "Kayıt Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (MesajSonuc == DialogResult.No)
            {
                MessageBox.Show("Personel Kayıt İşlemi İptal Edildi", "Kayıt Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            KayitEkle();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog F = new OpenFileDialog();
            F.Filter = "JPG (*.JPG)|*.jpg";
            if (F.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(F.FileName);
                pictureBox1.Image = File;
                ResimYolu = F.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog F = new SaveFileDialog();
            F.Filter = "JPG (*.JPG)|*.jpg";
            if (F.ShowDialog() == DialogResult.OK)
            {
                File.Save(F.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult Resim = MessageBox.Show("Fotoğraf Bölümünü Boş Bırakmak İstiyormusun", "Kayıt Uyarı Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (Resim == DialogResult.OK)
            {

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var PersonelKayit = new PersonelKayit();
            PersonelKayit.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult MesajSonuc = MessageBox.Show("Tüm Verileri Silmek İstiyormusun", "Kontrol Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (MesajSonuc == DialogResult.Yes)
            {
                PersonelList.Items.Clear();
            }
            if (MesajSonuc == DialogResult.No)
            {
                MessageBox.Show("Veri Silme İşlemini İptal Ettiniz", "Kontrol Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult SecilenSonuc = MessageBox.Show("Seçilen Veriyi Silmek İstiyormusun", "Kontrol Paneli", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (SecilenSonuc == DialogResult.Yes)
            {
                int SecilenKayit = PersonelList.SelectedIndex;
                if (SecilenKayit != -1)
                {
                    PersonelList.Items.RemoveAt(SecilenKayit);
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Veri Seçin", "Kontrol Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (SecilenSonuc == DialogResult.No)
                {
                    MessageBox.Show("Veri Silme İşlemini İptal Ettiniz", "Kontrol Paneli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

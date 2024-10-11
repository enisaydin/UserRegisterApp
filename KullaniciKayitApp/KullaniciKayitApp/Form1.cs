using KullaniciKayitApp.Models;
using System.Data.Entity;

namespace KullaniciKayitApp
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();

            string soyad = txtSoyad.Text.Trim();

            string email = txtEmail.Text.Trim();

            string yas = txtYas.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(yas))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newuser = new User
            {
                Ad = ad,
                Soyad = soyad,
                Email = email,
                Yas = yas
            };

            try
            {
                _context.Users.Add(newuser);
                _context.SaveChanges();
                MessageBox.Show("Kullanýcý baþarýyla kaydedildi.", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAd.Clear();
                txtSoyad.Clear();
                txtYas.Clear();
                txtEmail.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void btnKayitGöster_Click(object sender, EventArgs e)
        {
            Form2 showusers = new Form2();
            showusers.ShowDialog();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using KullaniciKayitApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciKayitApp
{
    public partial class Form2 : Form
    {
        private AppDbContext _context;

        public Form2()
        {

            InitializeComponent();
            _context = new AppDbContext();
        }
        private void LoadUsers()
        {
            try
            {
                var users = _context.Users.ToList();
                dataGridViewUsers.DataSource = users;
                dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler alınırken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Seçili Kullanıcı silmek istiyor musnuz ?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int selectedUserId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["UserId"].Value);
                        var user = _context.Users.Find(selectedUserId);
                        if(user != null)
                        {
                            _context.Users.Remove(user);
                            _context.SaveChanges();
                            MessageBox.Show("Kullanıcı başarıyla silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Silme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
        }
    }
}

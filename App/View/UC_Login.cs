using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TanamAja.App.Context;
using TanamAja.App.Models;

namespace TanamAja.App.View
{
    public partial class UC_Login : UserControl
    {
        public event EventHandler RegisterClicked;
        public UC_Login()
        {
            InitializeComponent();

            textPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text.Trim();
            string password = textPassword.Text.Trim();

            // Validasi input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nama pengguna dan kata sandi harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Buat instance context untuk autentikasi
                C_Users userContext = new C_Users();
                Users loggedInUser = userContext.AuthenticateUser(username, password);

                if (loggedInUser != null)
                {
                    // Cek role pengguna
                    if (loggedInUser.role == "admin")
                    {
                        MessageBox.Show("Login berhasil sebagai admin! Selamat datang, " + loggedInUser.username + ".", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Buka dashboard admin
                        DashboardAdmin adminDashboard = new DashboardAdmin();
                        adminDashboard.Show();

                        // Sembunyikan form login
                        Form parentForm = this.FindForm(); // Dapatkan referensi ke form utama
                        parentForm?.Hide(); // Sembunyikan form login
                    }
                    else if (loggedInUser.role == "customer")
                    {
                        MessageBox.Show("Login berhasil! Selamat datang, " + loggedInUser.username + ".", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Buka dashboard customer
                        DashboardCustomer customerDashboard = new DashboardCustomer();
                        customerDashboard.Show();

                        // Sembunyikan form login
                        Form parentForm = this.FindForm(); // Dapatkan referensi ke form utama
                        parentForm?.Hide(); // Sembunyikan form login
                    }
                    else
                    {
                        MessageBox.Show("Role tidak valid untuk login ini.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nama pengguna atau kata sandi salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void klikDaftar_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PanelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

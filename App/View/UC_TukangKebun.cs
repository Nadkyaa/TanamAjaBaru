using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanamAja.App.View
{
    public partial class FormKangKebun : UserControl
    {
        public FormKangKebun()
        {
            InitializeComponent();

            // Tambahkan style hover untuk button1 (atau lainnya jika ada)
            SetButtonHoverStyle(btnProfilAdmin);
            SetButtonHoverStyle(btnKatalog);
            SetButtonHoverStyle(btnKangKebun);
            SetButtonHoverStyle(btnRiwayatAdmin);
            SetButtonHoverStyle(btnLogOutAdmin);
        }

        // Method untuk mengatur style hover button
        private void SetButtonHoverStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat; // Mengubah style button menjadi datar
            button.FlatAppearance.BorderSize = 1; // Mengatur ketebalan border button
            button.FlatAppearance.BorderColor = Color.Black; // Warna border
            button.FlatAppearance.MouseOverBackColor = Color.SandyBrown; // Warna hover
            button.FlatAppearance.CheckedBackColor = Color.SandyBrown; // Warna saat aktif
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        private void FormKangKebun_Load(object sender, EventArgs e)
        {
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {

        }

        private void btnKangKebun_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayatAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOutAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}

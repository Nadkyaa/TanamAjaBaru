﻿using System;
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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            UC_DashboardCustomer uC_DashboardCustomer = new UC_DashboardCustomer();
            AddUserControl(uC_DashboardCustomer);

            // Tambahkan event handler untuk btnTukangKebun
            btnTukangKebun.Click += btnTukangKebun_Click;

            // Atur style hover untuk button
            SetButtonHoverStyle(btnKatalog);
            SetButtonHoverStyle(btnTukangKebun);
            SetButtonHoverStyle(btnPesanan);
            SetButtonHoverStyle(btnRiwayat);
        }

        // Method untuk mengatur style hover button
        private void SetButtonHoverStyle(Button button)
        {
            button.FlatStyle = FlatStyle.Flat; //Mengubah style button menjadi tampilan datar (flat) dan Menghilangkan efek 3D bawaan Windows
            button.FlatAppearance.BorderSize = 1; //Mengatur ketebalan border button menjadi 1 pixel
            button.FlatAppearance.BorderColor = Color.Black; //Mengatur warna border button menjadi hitam
            button.FlatAppearance.MouseOverBackColor = Color.SandyBrown; //Mengatur warna background saat mouse berada di atas button
            button.FlatAppearance.CheckedBackColor = Color.Yellow; //Akan memberikan warna kuning saat button dalam keadaan aktif/dipilih
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
        }

        private void DashboardCustomer_Load(object sender, EventArgs e)
        {
        }

        private void AddUserControl(UserControl userControl)
        {
            // Mengatur UserControl agar mengisi panel
            userControl.Dock = DockStyle.Fill;
            tempatDashboardCustomer.Controls.Clear();
            tempatDashboardCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void tempatDashboardCustomer_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnTukangKebun_Click(object sender, EventArgs e)
        {
            // Cek apakah form sudah terbuka
            FormTukangKebun existingForm = Application.OpenForms.OfType<FormTukangKebun>().FirstOrDefault();
            if (existingForm == null)
            {
                // Jika form belum terbuka, buat dan tampilkan form baru
                FormTukangKebun tukangKebunForm = new FormTukangKebun();
                this.Hide(); // Sembunyikan DashboardAdmin
                tukangKebunForm.Show();
                tukangKebunForm.FormClosed += (s, args) =>
                {
                };
            }
            else
            {
                // Jika form sudah terbuka, aktifkan form tersebut
                existingForm.Activate();
                existingForm.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            UC_RiwayatAdmin uC_RiwayatAdmin = new UC_RiwayatAdmin();
            AddUserControl (uC_RiwayatAdmin);
        }
    }
}
namespace TanamAja.App.View
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            btnTukangKebun = new Button();
            btnRiwayat = new Button();
            btnPesanan = new Button();
            btnKatalog = new Button();
            colorDialog1 = new ColorDialog();
            tempatDashboardCustomer = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Dashboard_Pinggir;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnTukangKebun);
            panel1.Controls.Add(btnRiwayat);
            panel1.Controls.Add(btnPesanan);
            panel1.Controls.Add(btnKatalog);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 1022);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(232, 236, 215);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.IkonKeluar;
            button1.Location = new Point(134, 911);
            button1.Name = "button1";
            button1.Size = new Size(118, 50);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnTukangKebun
            // 
            btnTukangKebun.BackColor = Color.FromArgb(187, 138, 82);
            btnTukangKebun.FlatAppearance.BorderSize = 0;
            btnTukangKebun.FlatStyle = FlatStyle.Flat;
            btnTukangKebun.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTukangKebun.Image = Properties.Resources.IkonProfil__1_;
            btnTukangKebun.Location = new Point(40, 735);
            btnTukangKebun.Name = "btnTukangKebun";
            btnTukangKebun.Size = new Size(320, 101);
            btnTukangKebun.TabIndex = 4;
            btnTukangKebun.Text = "    Tukang Kebun";
            btnTukangKebun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTukangKebun.UseVisualStyleBackColor = false;
            btnTukangKebun.Click += btnTukangKebun_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(187, 138, 82);
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.Image = Properties.Resources.Ikon_Riwayat__1_;
            btnRiwayat.Location = new Point(40, 548);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(320, 101);
            btnRiwayat.TabIndex = 3;
            btnRiwayat.Text = "    Riwayat Pesanan";
            btnRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnPesanan
            // 
            btnPesanan.BackColor = Color.FromArgb(187, 138, 82);
            btnPesanan.FlatAppearance.BorderSize = 0;
            btnPesanan.FlatStyle = FlatStyle.Flat;
            btnPesanan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesanan.Image = Properties.Resources.IkonPesanan__2_;
            btnPesanan.Location = new Point(40, 367);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(320, 101);
            btnPesanan.TabIndex = 2;
            btnPesanan.Text = "        Pesanan";
            btnPesanan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesanan.UseVisualStyleBackColor = false;
            btnPesanan.Click += btnPesanan_Click;
            // 
            // btnKatalog
            // 
            btnKatalog.BackColor = Color.FromArgb(187, 138, 82);
            btnKatalog.BackgroundImageLayout = ImageLayout.None;
            btnKatalog.Cursor = Cursors.Hand;
            btnKatalog.FlatAppearance.BorderSize = 0;
            btnKatalog.FlatStyle = FlatStyle.Flat;
            btnKatalog.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalog.Image = Properties.Resources.IkonKatalog__1_;
            btnKatalog.Location = new Point(40, 185);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(320, 101);
            btnKatalog.TabIndex = 0;
            btnKatalog.Text = "          Katalog";
            btnKatalog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKatalog.UseVisualStyleBackColor = false;
            btnKatalog.Click += btnKatalog_Click;
            // 
            // tempatDashboardCustomer
            // 
            tempatDashboardCustomer.Location = new Point(422, 12);
            tempatDashboardCustomer.Name = "tempatDashboardCustomer";
            tempatDashboardCustomer.Size = new Size(1468, 1009);
            tempatDashboardCustomer.TabIndex = 1;
            tempatDashboardCustomer.Paint += tempatDashboardCustomer_Paint;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tempatDashboardCustomer);
            Controls.Add(panel1);
            Name = "DashboardAdmin";
            Text = "Dashboard";
            Load += DashboardCustomer_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKatalog;
        private Button btnPesanan;
        private ColorDialog colorDialog1;
        private Button btnTukangKebun;
        private Button btnRiwayat;
        private Panel tempatDashboardCustomer;
        private Button button1;
    }
}
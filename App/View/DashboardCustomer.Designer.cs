namespace TanamAja.App.View
{
    partial class DashboardCustomer
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
            tempatDashboardCustomer = new Panel();
            panel1 = new Panel();
            btnRiwayat = new Button();
            button1 = new Button();
            btnBeranda = new Button();
            btnProfilCustomer = new Button();
            tempatDashboardCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tempatDashboardCustomer
            // 
            tempatDashboardCustomer.BackgroundImage = Properties.Resources.CUSTOMER_Beranda_3;
            tempatDashboardCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            tempatDashboardCustomer.Controls.Add(panel1);
            tempatDashboardCustomer.Controls.Add(btnRiwayat);
            tempatDashboardCustomer.Controls.Add(button1);
            tempatDashboardCustomer.Controls.Add(btnBeranda);
            tempatDashboardCustomer.Controls.Add(btnProfilCustomer);
            tempatDashboardCustomer.Location = new Point(188, 84);
            tempatDashboardCustomer.Name = "tempatDashboardCustomer";
            tempatDashboardCustomer.Size = new Size(1526, 864);
            tempatDashboardCustomer.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(221, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 601);
            panel1.TabIndex = 4;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(187, 138, 82);
            btnRiwayat.FlatAppearance.BorderSize = 0;
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnRiwayat.Image = Properties.Resources.Ikon_Riwayat__1_;
            btnRiwayat.Location = new Point(1014, 30);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(290, 61);
            btnRiwayat.TabIndex = 3;
            btnRiwayat.Text = "   Riwayat Pesanan";
            btnRiwayat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 138, 82);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.IkonPesanan__2_;
            button1.Location = new Point(632, 31);
            button1.Name = "button1";
            button1.Size = new Size(290, 60);
            button1.TabIndex = 2;
            button1.Text = "     Pesanan";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.FromArgb(187, 138, 82);
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 128);
            btnBeranda.Image = Properties.Resources.IkonKatalog__1_;
            btnBeranda.Location = new Point(238, 30);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(290, 60);
            btnBeranda.TabIndex = 1;
            btnBeranda.Text = "     Beranda";
            btnBeranda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnProfilCustomer
            // 
            btnProfilCustomer.BackColor = Color.FromArgb(232, 236, 215);
            btnProfilCustomer.FlatAppearance.BorderSize = 0;
            btnProfilCustomer.FlatStyle = FlatStyle.Flat;
            btnProfilCustomer.Image = Properties.Resources.IkonProfilUser__1_;
            btnProfilCustomer.Location = new Point(1332, 50);
            btnProfilCustomer.Name = "btnProfilCustomer";
            btnProfilCustomer.Size = new Size(151, 72);
            btnProfilCustomer.TabIndex = 0;
            btnProfilCustomer.UseVisualStyleBackColor = false;
            // 
            // DashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 236, 215);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tempatDashboardCustomer);
            Name = "DashboardCustomer";
            Text = "Dashboard";
            Load += DashboardCustomer_Load;
            tempatDashboardCustomer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel tempatDashboardCustomer;
        private Button btnProfilCustomer;
        private Button btnBeranda;
        private Button btnRiwayat;
        private Button button1;
        private Panel panel1;
    }
}
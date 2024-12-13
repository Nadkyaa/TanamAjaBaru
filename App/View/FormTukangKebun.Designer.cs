namespace TanamAja.App.View
{
    partial class FormTukangKebun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTukangKebun));
            btnProfilAdmin = new Button();
            btnLogoutAdmin = new Button();
            btnKatalogAdmin = new Button();
            btnRiwayatAdmin = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnProfilAdmin
            // 
            btnProfilAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnProfilAdmin.FlatAppearance.BorderSize = 0;
            btnProfilAdmin.FlatStyle = FlatStyle.Flat;
            btnProfilAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfilAdmin.ForeColor = Color.Black;
            btnProfilAdmin.Location = new Point(188, 178);
            btnProfilAdmin.Margin = new Padding(2);
            btnProfilAdmin.Name = "btnProfilAdmin";
            btnProfilAdmin.Size = new Size(146, 88);
            btnProfilAdmin.TabIndex = 0;
            btnProfilAdmin.Text = "Profil";
            btnProfilAdmin.TextImageRelation = TextImageRelation.TextAboveImage;
            btnProfilAdmin.UseVisualStyleBackColor = false;
            // 
            // btnLogoutAdmin
            // 
            btnLogoutAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnLogoutAdmin.FlatAppearance.BorderSize = 0;
            btnLogoutAdmin.FlatStyle = FlatStyle.Flat;
            btnLogoutAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogoutAdmin.ForeColor = Color.Black;
            btnLogoutAdmin.Location = new Point(172, 841);
            btnLogoutAdmin.Margin = new Padding(2);
            btnLogoutAdmin.Name = "btnLogoutAdmin";
            btnLogoutAdmin.Size = new Size(162, 87);
            btnLogoutAdmin.TabIndex = 1;
            btnLogoutAdmin.Text = "Logout";
            btnLogoutAdmin.UseVisualStyleBackColor = false;
            btnLogoutAdmin.Click += btnLogoutAdmin_Click;
            // 
            // btnKatalogAdmin
            // 
            btnKatalogAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnKatalogAdmin.FlatAppearance.BorderSize = 0;
            btnKatalogAdmin.FlatStyle = FlatStyle.Flat;
            btnKatalogAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKatalogAdmin.ForeColor = Color.Black;
            btnKatalogAdmin.Location = new Point(180, 340);
            btnKatalogAdmin.Margin = new Padding(2);
            btnKatalogAdmin.Name = "btnKatalogAdmin";
            btnKatalogAdmin.Size = new Size(154, 89);
            btnKatalogAdmin.TabIndex = 2;
            btnKatalogAdmin.Text = "Katalog";
            btnKatalogAdmin.UseVisualStyleBackColor = false;
            // 
            // btnRiwayatAdmin
            // 
            btnRiwayatAdmin.BackColor = Color.FromArgb(187, 138, 82);
            btnRiwayatAdmin.FlatAppearance.BorderSize = 0;
            btnRiwayatAdmin.FlatStyle = FlatStyle.Flat;
            btnRiwayatAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatAdmin.ForeColor = Color.Black;
            btnRiwayatAdmin.Location = new Point(173, 671);
            btnRiwayatAdmin.Margin = new Padding(2);
            btnRiwayatAdmin.Name = "btnRiwayatAdmin";
            btnRiwayatAdmin.Size = new Size(161, 89);
            btnRiwayatAdmin.TabIndex = 4;
            btnRiwayatAdmin.Text = "Riwayat";
            btnRiwayatAdmin.UseVisualStyleBackColor = false;
            btnRiwayatAdmin.Click += btnRiwayatAdmin_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(668, 296);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(959, 502);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(109, 151, 115);
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1492, 888);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(213, 79);
            button1.TabIndex = 6;
            button1.Text = "TAMBAH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormTukangKebun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnRiwayatAdmin);
            Controls.Add(btnKatalogAdmin);
            Controls.Add(btnLogoutAdmin);
            Controls.Add(btnProfilAdmin);
            Margin = new Padding(2);
            Name = "FormTukangKebun";
            Text = "FormTukangKebun";
            Load += FormTukangKebun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfilAdmin;
        private Button btnLogoutAdmin;
        private Button btnKatalogAdmin;
        private Button btnRiwayatAdmin;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
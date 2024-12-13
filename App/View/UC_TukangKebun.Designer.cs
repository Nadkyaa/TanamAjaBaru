namespace TanamAja.App.View
{
    partial class FormKangKebun
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKangKebun));
            btnProfilAdmin = new Button();
            btnKatalog = new Button();
            btnKangKebun = new Button();
            btnRiwayatAdmin = new Button();
            btnLogOutAdmin = new Button();
            SuspendLayout();
            // 
            // btnProfilAdmin
            // 
            btnProfilAdmin.AutoSize = true;
            btnProfilAdmin.BackColor = Color.Transparent;
            btnProfilAdmin.FlatStyle = FlatStyle.Flat;
            btnProfilAdmin.Font = new Font("Segoe UI", 1F);
            btnProfilAdmin.ForeColor = Color.Peru;
            btnProfilAdmin.Location = new Point(57, 166);
            btnProfilAdmin.Name = "btnProfilAdmin";
            btnProfilAdmin.Size = new Size(316, 111);
            btnProfilAdmin.TabIndex = 0;
            btnProfilAdmin.Text = "button1";
            btnProfilAdmin.UseVisualStyleBackColor = false;
            btnProfilAdmin.Click += button1_Click;
            // 
            // btnKatalog
            // 
            btnKatalog.AutoSize = true;
            btnKatalog.BackColor = Color.Transparent;
            btnKatalog.FlatStyle = FlatStyle.Flat;
            btnKatalog.Font = new Font("Segoe UI", 1F);
            btnKatalog.ForeColor = Color.Peru;
            btnKatalog.Location = new Point(57, 328);
            btnKatalog.Name = "btnKatalog";
            btnKatalog.Size = new Size(316, 111);
            btnKatalog.TabIndex = 1;
            btnKatalog.Text = "button2";
            btnKatalog.UseVisualStyleBackColor = false;
            btnKatalog.Click += btnKatalog_Click;
            // 
            // btnKangKebun
            // 
            btnKangKebun.BackColor = Color.Transparent;
            btnKangKebun.FlatStyle = FlatStyle.Flat;
            btnKangKebun.Font = new Font("Segoe UI", 1F);
            btnKangKebun.ForeColor = Color.Peru;
            btnKangKebun.Location = new Point(57, 494);
            btnKangKebun.Name = "btnKangKebun";
            btnKangKebun.Size = new Size(316, 111);
            btnKangKebun.TabIndex = 2;
            btnKangKebun.Text = "button3";
            btnKangKebun.UseVisualStyleBackColor = false;
            btnKangKebun.Click += btnKangKebun_Click;
            // 
            // btnRiwayatAdmin
            // 
            btnRiwayatAdmin.BackColor = Color.Transparent;
            btnRiwayatAdmin.FlatStyle = FlatStyle.Flat;
            btnRiwayatAdmin.Font = new Font("Segoe UI", 1F);
            btnRiwayatAdmin.ForeColor = Color.Peru;
            btnRiwayatAdmin.Location = new Point(57, 659);
            btnRiwayatAdmin.Name = "btnRiwayatAdmin";
            btnRiwayatAdmin.Size = new Size(316, 111);
            btnRiwayatAdmin.TabIndex = 3;
            btnRiwayatAdmin.Text = "button4";
            btnRiwayatAdmin.UseVisualStyleBackColor = false;
            btnRiwayatAdmin.Click += btnRiwayatAdmin_Click;
            // 
            // btnLogOutAdmin
            // 
            btnLogOutAdmin.BackColor = Color.Transparent;
            btnLogOutAdmin.FlatStyle = FlatStyle.Flat;
            btnLogOutAdmin.Font = new Font("Segoe UI", 1F);
            btnLogOutAdmin.ForeColor = Color.Peru;
            btnLogOutAdmin.Location = new Point(56, 828);
            btnLogOutAdmin.Name = "btnLogOutAdmin";
            btnLogOutAdmin.Size = new Size(316, 111);
            btnLogOutAdmin.TabIndex = 4;
            btnLogOutAdmin.Text = "button5";
            btnLogOutAdmin.UseVisualStyleBackColor = false;
            btnLogOutAdmin.Click += btnLogOutAdmin_Click;
            // 
            // FormKangKebun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnLogOutAdmin);
            Controls.Add(btnRiwayatAdmin);
            Controls.Add(btnKangKebun);
            Controls.Add(btnKatalog);
            Controls.Add(btnProfilAdmin);
            Name = "FormKangKebun";
            Size = new Size(1920, 1080);
            Load += FormKangKebun_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProfilAdmin;
        private Button btnKatalog;
        private Button btnKangKebun;
        private Button btnRiwayatAdmin;
        private Button btnLogOutAdmin;
    }
}

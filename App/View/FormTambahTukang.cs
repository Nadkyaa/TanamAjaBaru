using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TanamAja.App.Models;

namespace TanamAja.App.View
{
    public partial class FormTambahTukang : Form
    {
        public M_TukangKebun TukangKebun { get; set; }
        public bool IsEditMode { get; set; } = false;

        public FormTambahTukang()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change text color based on selection
            string selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "Perempuan" || selectedItem == "Laki-laki")
            {
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=perdani;Database=DatabaseTanamaja;"))
                {
                    connection.Open();

                    string query;
                    if (TukangKebun != null)
                    {
                        query = @"
                    UPDATE TukangKebun 
                    SET nama = @nama, alamat = @alamat, notelefon = @notelefon, 
                        jeniskelamin = @jeniskelamin::jeniskelaminenum
                    WHERE id_tukangkebun = @id";
                    }
                    else
                    {
                        query = @"
                    INSERT INTO TukangKebun (nama, alamat, notelefon, jeniskelamin) 
                    VALUES (@nama, @alamat, @notelefon, @jeniskelamin::jeniskelaminenum)";
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@nama", textBox2.Text);
                        command.Parameters.AddWithValue("@alamat", textBox3.Text);
                        command.Parameters.AddWithValue("@notelefon", textBox4.Text);

                        // Add and validate gender
                        string genderValue = comboBox1.SelectedItem?.ToString();
                        if (genderValue != "Laki-laki" && genderValue != "Perempuan")
                        {
                            MessageBox.Show("Jenis kelamin tidak valid.");
                            return;
                        }
                        command.Parameters.AddWithValue("@jeniskelamin", genderValue);

                        if (TukangKebun != null)
                        {
                            command.Parameters.AddWithValue("@id", TukangKebun.id_tukangkebun);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil disimpan.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menyimpan data: {ex.Message}");
            }
        }


        private void FormTambahTukang_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with gender options
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Laki-laki");
            comboBox1.Items.Add("Perempuan");

            if (TukangKebun != null)
            {
                // Populate form fields for edit mode
                textBox2.Text = TukangKebun.nama;
                textBox3.Text = TukangKebun.alamat;
                textBox4.Text = TukangKebun.notelefon;
                comboBox1.SelectedItem = TukangKebun.jeniskelamin;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cancel button to return to the previous form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

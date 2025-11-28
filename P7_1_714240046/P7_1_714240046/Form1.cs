using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714240046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(333, 254); // ukuran awal form (mengecil)
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
                errorMessage.AppendLine("Nama harus diisi!");
            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
                errorMessage.AppendLine("Kelas harus diisi!");
            if (comboBoxAngkatan.SelectedIndex == -1)
                errorMessage.AppendLine("Angkatan harus dipilih!");

            string errorString = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorString))
            {
                MessageBox.Show("Lengkap",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // langkah 7 (perbesar ukuran form)
                this.Size = new Size(428, 571);  // ukuran penuh yang kamu gunakan
            }
            else
            {
                MessageBox.Show(errorString.Trim(),
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKuliah.Enabled = true;
            checkBoxTidur.Enabled = true;
            checkBoxLiburan.Enabled = false;

            checkBoxKuliah.Checked = false;
            checkBoxTidur.Checked = false;
            checkBoxLiburan.Checked = false;
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxKuliah.Enabled = false;
            checkBoxTidur.Enabled = true;
            checkBoxLiburan.Enabled = true;

            checkBoxKuliah.Checked = false;
            checkBoxTidur.Checked = false;
            checkBoxLiburan.Checked = false;

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string hari = "";
            string kegiatan = "";

            // cek hari
            foreach (Control c in this.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    hari = rb.Text;
                    break;
                }
            }

            // cek kegiatan
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox cb && cb.Checked)
                {
                    if (kegiatan == "")
                        kegiatan = cb.Text;
                    else
                        kegiatan += ", " + cb.Text;
                }
            }

            MessageBox.Show(
                "Nama: " + textBoxNama.Text + "\n" +
                "Angkatan: " + comboBoxAngkatan.Text + "\n" +
                "Kelas: " + textBoxKelas.Text + "\n" +
                "Hari: " + hari + "\n" +
                "Kegiatan: " + kegiatan,
                "Informasi Data Submit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb) tb.Clear();
                if (c is ComboBox cb) cb.SelectedIndex = -1;
                if (c is RadioButton rb) rb.Checked = false;
                if (c is CheckBox ck) ck.Checked = false;
            }

            // ukuran kembali ke awal (sesuai constructor)
            this.Size = new Size(333, 254);

            MessageBox.Show("Form berhasil di-reset!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void comboBoxAngkatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

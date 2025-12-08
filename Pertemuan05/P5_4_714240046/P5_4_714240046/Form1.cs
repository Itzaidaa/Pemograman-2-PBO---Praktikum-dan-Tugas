using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P5_4_714240046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hubungkan tombol ke event
            btnsimpan.Click += btnsimpan_Click;
            btnbatal.Click += btnbatal_Click;
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            // === VALIDASI KELAS ===
            bool kelasDipilih =
                checkBox1.Checked ||         // Sepak Bola
                checBoxBulu.Checked ||       // Bulu Tangkis
                checkBasket.Checked ||       // Basket
                checkBoxRenang.Checked ||    // Renang
                checkBoxTenis.Checked ||     // Tenis
                checkBoxVoli.Checked ||      // Voli
                checkBoxYoga.Checked ||      // Yoga
                checkBoxPanahan.Checked;     // Panahan

            if (!kelasDipilih)
            {
                MessageBox.Show(
                    "Harus memilih salah satu dari pilihan kelas",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // === VALIDASI JADWAL ===
            bool jadwalDipilih =
                radioSenin.Checked ||
                radioSelasa.Checked ||
                radioSabtu.Checked ||
                radioMinggu.Checked;

            if (!jadwalDipilih)
            {
                MessageBox.Show(
                    "Harus memilih salah satu dari pilihan jadwal",
                    "Warning!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // === AMBIL DATA INPUT ===
            string nama = textBoxNama.Text;
            string gender = comboBoxJK.Text;
            string tgl = dateTimePickerTgl.Value.ToString("dd MMMM yyyy");

            // === KELAS DIPILIH ===
            List<string> kelas = new List<string>();

            if (checkBox1.Checked) kelas.Add("Sepak Bola");
            if (checBoxBulu.Checked) kelas.Add("Bulu Tangkis");
            if (checkBasket.Checked) kelas.Add("Basket");
            if (checkBoxRenang.Checked) kelas.Add("Renang");
            if (checkBoxTenis.Checked) kelas.Add("Tenis");
            if (checkBoxVoli.Checked) kelas.Add("Voli");
            if (checkBoxYoga.Checked) kelas.Add("Yoga");
            if (checkBoxPanahan.Checked) kelas.Add("Panahan");

            string kelasStr = string.Join(", ", kelas);

            // === JADWAL DIPILIH ===
            string jadwal = "";
            if (radioSenin.Checked) jadwal = "Senin s/d Rabu, 14.00 – 16.00";
            if (radioSelasa.Checked) jadwal = "Selasa s/d Kamis, 14.00 – 16.00";
            if (radioSabtu.Checked) jadwal = "Sabtu s/d Minggu, 09.00 – 11.00";
            if (radioMinggu.Checked) jadwal = "Minggu, 13.00 – 20.00";

            // === TAMPILKAN DATA ===
            string pesan =
                $"Nama : {nama}\n" +
                $"Jenis Kelamin : {gender}\n" +
                $"Tanggal Lahir : {tgl}\n" +
                $"Pilihan Kelas : {kelasStr}\n" +
                $"Pilihan Jadwal : {jadwal}";

            MessageBox.Show(
                pesan,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
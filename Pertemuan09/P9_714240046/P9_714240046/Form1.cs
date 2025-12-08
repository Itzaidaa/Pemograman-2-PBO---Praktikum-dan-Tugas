using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P9_714240046   // pastikan sama dengan namespace di project
{
    public partial class Form1 : Form
    {
        koneksi koneksi = new koneksi();  // panggil koneksi

        public Form1()
        {
            InitializeComponent();
        }

        // ================= TAMPIL DATA =================
        public void Tampil()
        {
            try
            {
                koneksi.OpenConn(); // buka koneksi

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM t_mahasiswa", koneksi.GetConn());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataMahasiswa.DataSource = dt;  // tampilkan data
                koneksi.CloseConn();            // tutup koneksi

                // Ubah nama header kolom
                DataMahasiswa.Columns[0].HeaderText = "NPM";
                DataMahasiswa.Columns[1].HeaderText = "Nama";
                DataMahasiswa.Columns[2].HeaderText = "Angkatan";
                DataMahasiswa.Columns[3].HeaderText = "Alamat";
                DataMahasiswa.Columns[4].HeaderText = "Email";
                DataMahasiswa.Columns[5].HeaderText = "No HP";

                // Auto full width
                DataMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data!\n" + ex.Message);
            }
        }

        // ================= LOAD FORM =================
        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();  // otomatis load data saat aplikasi dibuka
        }

        // ===== EVENT DEFAULT (BIARKAN, JANGAN DIHAPUS) =====
        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void DataMahasiswa_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}

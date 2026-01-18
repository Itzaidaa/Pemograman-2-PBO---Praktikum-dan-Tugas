using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_714240046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("colNo", "No");
            dataGridView1.Columns.Add("colIdBarang", "ID Barang");
            dataGridView1.Columns.Add("colNama", "Nama Barang");
            dataGridView1.Columns.Add("colHarga", "Harga");
            dataGridView1.Columns.Add("colQty", "QTY");
            dataGridView1.Columns.Add("colTotal", "Total Harga");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "TransaksiBarang.xlsx";
            save.OverwritePrompt = false;

            if (save.ShowDialog() == DialogResult.OK)
            {
                string filePath = save.FileName;

                if (File.Exists(filePath))
                    File.Delete(filePath);

                Excel excelLib = new Excel();
                excelLib.ExportToExcel(dataGridView1, filePath);

                MessageBox.Show(
                    "Data berhasil diekspor ke file Excel.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            int no = dataGridView1.Rows.Count + 1;

            // Bersihkan Rp dan titik
            string hargaText = textBox2.Text
                .Replace("Rp", "")
                .Replace(".", "")
                .Trim();

            string qtyText = textBox3.Text.Trim();

            int harga = int.Parse(hargaText);
            int qty = int.Parse(qtyText);
            int total = harga * qty;

            dataGridView1.Rows.Add(
                no,
                comboBox1.Text,          // ID Barang
                textBox1.Text,           // Nama Barang
                $"Rp {harga:N0}",        // Harga
                qty,                     // QTY
                $"Rp {total:N0}"         // Total Harga
            );
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string hargaText = textBox2.Text
                .Replace("Rp", "")
                .Replace(".", "")
                .Trim();

            if (int.TryParse(hargaText, out int harga) &&
                int.TryParse(textBox3.Text, out int qty))
            {
                int total = harga * qty;
                textBox4.Text = total.ToString("N0");
            }
        }


    }

}


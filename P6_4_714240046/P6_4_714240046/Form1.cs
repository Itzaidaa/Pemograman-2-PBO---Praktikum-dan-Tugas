using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_4_714240046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtRequired_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequired.Text))
            {
                MessageBox.Show("Field Required harus diisi!");
                return;
            }
        }

        private void txtRegex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(txtRegex.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtA.Text != txtB.Text)
            {
                MessageBox.Show("TextBox A dan B harus sama!");
                return;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtA.Text != txtB.Text)
            {
                MessageBox.Show("TextBox A dan B harus sama!");
                return;
            }
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLength.Text.Length < 5)
            {
                MessageBox.Show("Minimal 5 karakter!");
                return;
            }
        }

        private void txtUpper_TextChanged(object sender, EventArgs e)
        {
            int pos = txtUpper.SelectionStart;
            txtUpper.Text = txtUpper.Text.ToUpper();
            txtUpper.SelectionStart = pos;
        }

        private void txtLower_TextChanged(object sender, EventArgs e)
        {
            int pos = txtLower.SelectionStart;
            txtLower.Text = txtLower.Text.ToLower();
            txtLower.SelectionStart = pos;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // REQUIRED
            if (string.IsNullOrWhiteSpace(txtRequired.Text))
            {
                MessageBox.Show("Field Required harus diisi!");
                return;
            }

            // REGEX
            if (!Regex.IsMatch(txtRegex.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            // COMPARISON
            if (txtA.Text != txtB.Text)
            {
                MessageBox.Show("TextBox A dan B harus sama!");
                return;
            }

            // LENGTH
            if (txtLength.Text.Length < 5)
            {
                MessageBox.Show("Minimal 5 karakter!");
                return;
            }

            // KALAU SEMUA VALID → TAMPILKAN MESSAGEBOX
            string output =
                $"Numeric      : {txtNumeric.Text}\n" +
                $"Char         : {txtChar.Text}\n" +
                $"Required     : {txtRequired.Text}\n" +
                $"Regex/Email  : {txtRegex.Text}\n" +
                $"A / B        : {txtA.Text} / {txtB.Text}\n" +
                $"Length       : {txtLength.Text}\n" +
                $"Upper Case   : {txtUpper.Text}\n" +
                $"Lower Case   : {txtLower.Text}";

            MessageBox.Show(output, "Hasil Form");
        }

    }
}

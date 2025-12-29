using StartUp.cs.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_714240046
{
    public partial class FormLogin : Form
    {
        CekLogin login = new CekLogin();   // ⬅️ INI YANG KAMU BELUM ADA

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show(
                    "Username dan Password tidak boleh kosong",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool status = login.cek_login(tbUsername.Text, tbPassword.Text);

            if (status)
            {
                MessageBox.Show(
                    "Login Berhasil",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ParentForm p = new ParentForm();
                this.Hide();
                p.Show();
            }
            else
            {
                MessageBox.Show(
                    "Username atau Password salah",
                    "Gagal Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
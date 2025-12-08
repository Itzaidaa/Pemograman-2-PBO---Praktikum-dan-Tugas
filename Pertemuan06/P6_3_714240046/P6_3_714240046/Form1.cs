using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_3_714240046
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAngka2_Click(object sender, EventArgs e)
        {

        }

        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void tbHuruf_Leave(object sender, EventArgs e)
        {
            if (tbHuruf.Text == "")
            {
                SetErrorMessages(tbHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (tbHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(tbHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(tbHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

    }
}

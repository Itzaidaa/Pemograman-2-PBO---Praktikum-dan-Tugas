using System;
using System.Windows.Forms;

namespace P12_714240046
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new StartUp());
            Application.Run(new FormLogin());
        }
    }
}

using System;
using System.Windows.Forms;

namespace UML_parser
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UML_parser());
        }
    }
}

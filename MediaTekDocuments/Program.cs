using System;
using System.Windows.Forms;
using MediaTekDocuments.view;

namespace MediaTekDocuments
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAuthentification());
        }
    }
}
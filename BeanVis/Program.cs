using System;
using System.Windows.Forms;
using BeanVis.Views;

namespace BeanVis
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Use the compatible RealTaiizor startup
            Application.Run(new MainForm());
        }
    }
}

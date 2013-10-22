using System;
using System.Windows.Forms;

namespace Yandex.Metrica.Sample.net45.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enter your ApiKey here
            // 1111 is ApiKey for Yandex.Metrica for Apps sample
            Counter.Start(1111);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // let counter save current state
            Counter.ReportExit();
        }
    }
}

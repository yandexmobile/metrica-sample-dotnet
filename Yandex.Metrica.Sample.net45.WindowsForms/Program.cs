using System;
using System.Windows.Forms;

namespace Yandex.Metrica.Sample.net45.WindowsForms
{
    static class Program
    {
        /* Replace API_KEY with your unique API key. Please, read official documentation how to obtain one:
         * https://tech.yandex.com/metrica-mobile-sdk/doc/mobile-sdk-dg/tasks/net-quickstart-docpage/
         */
        private const string ApiKey = "API_KEY";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            YandexMetrica.Activate(ApiKey);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // let counter save current state
            YandexMetrica.ReportExit();
        }
    }
}

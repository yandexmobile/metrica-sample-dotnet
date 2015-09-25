using System.Windows;

namespace Yandex.Metrica.Sample
{
    public partial class App
    {
        /* Replace API_KEY with your unique API key. Please, read official documentation how to obtain one:
         * https://tech.yandex.com/metrica-mobile-sdk/doc/mobile-sdk-dg/tasks/net-quickstart-docpage/
         */
        private const string ApiKey = "API_KEY";

        public App()
        {
            YandexMetrica.Activate(ApiKey);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // let counter save current state
            YandexMetrica.ReportExit();

            base.OnExit(e);
        }
    }
}

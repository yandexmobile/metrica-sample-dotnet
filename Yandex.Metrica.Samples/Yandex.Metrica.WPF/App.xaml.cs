using System.Windows;

namespace Yandex.Metrica.Sample
{
    public partial class App
    {
        public App()
        {
            YandexMetrica.Activate("141aee51-f778-4951-adb8-97d811aa06e1");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // let counter save current state
            YandexMetrica.ReportExit();

            base.OnExit(e);
        }
    }
}

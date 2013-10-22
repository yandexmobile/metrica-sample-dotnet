using System.Windows;

namespace Yandex.Metrica.Sample
{
    public partial class App
    {
        public App()
        {
            // Enter your ApiKey here
            // 1111 is ApiKey for Yandex.Metrica for Apps sample
            Counter.Start(1111);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // let counter save current state
            Counter.ReportExit();

            base.OnExit(e);
        }
    }
}

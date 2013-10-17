using System.Windows;

namespace Yandex.Metrica.Sample
{
    public partial class App
    {
        public App()
        {
            Counter.Start(5680);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // let counter save current state
            Counter.ReportExit();

            base.OnExit(e);
        }
    }
}

using System.Windows;
using Yandex.Metrica;

namespace AppMetrica.Demo
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            YandexMetrica.Activate("Yours Api Key");
        }
    }
}

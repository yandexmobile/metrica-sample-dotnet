using System.Windows;
using Yandex.Metrica;

namespace AppMetrica.Demo
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            YandexMetrica.Activate("141aee51-f778-4951-adb8-97d811aa06e1");
        }
    }
}

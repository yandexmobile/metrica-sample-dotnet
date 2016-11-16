using System.Windows;
using Yandex.Metrica;

namespace AppMetrica.Demo
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            //TODO: https://tech.yandex.com/metrica-mobile-sdk/doc/mobile-sdk-dg/tasks/winphone-quickstart-docpage/
            YandexMetrica.Activate("Yours Api Key");
        }
    }
}

using Yandex.Metrica;
using Windows.ApplicationModel.Background;

namespace AppMetricaTask
{
    public sealed class AppTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var deferral = taskInstance.GetDeferral();
            YandexMetrica.Config.LocationTracking = false;
            //TODO: https://tech.yandex.com/metrica-mobile-sdk/doc/mobile-sdk-dg/tasks/winphone-quickstart-docpage/
            YandexMetrica.Activate("Yours Api Key");
            YandexMetrica.ReportEvent("Hello from background!");
            YandexMetrica.Snapshot();
            deferral.Complete();
        }
    }
}

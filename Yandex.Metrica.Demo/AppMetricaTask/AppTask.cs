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
            YandexMetrica.Activate("141aee51-f778-4951-adb8-97d811aa06e1");
            YandexMetrica.ReportEvent("Hello from background!");
            YandexMetrica.Snapshot();
            deferral.Complete();
        }
    }
}

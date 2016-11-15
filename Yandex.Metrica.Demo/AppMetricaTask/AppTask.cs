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
            YandexMetrica.Activate("Yours Api Key");
            YandexMetrica.ReportEvent("Hello from background!");
            YandexMetrica.Snapshot();
            deferral.Complete();
        }
    }
}

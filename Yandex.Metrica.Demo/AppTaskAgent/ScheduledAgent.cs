using System.Diagnostics;
using System.Windows;
using Microsoft.Phone.Scheduler;
using Yandex.Metrica;

namespace AppTaskAgent
{
    public class ScheduledAgent : ScheduledTaskAgent
    {
        /// <remarks>
        /// ScheduledAgent constructor, initializes the UnhandledException handler
        /// </remarks>
        static ScheduledAgent()
        {
            // Subscribe to the managed exception handler
            Deployment.Current.Dispatcher.BeginInvoke(delegate
            {
                Application.Current.UnhandledException += UnhandledException;
            });
        }

        /// Code to execute on Unhandled Exceptions
        private static void UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                Debugger.Break();
            }
        }

        /// <summary>
        /// Agent that runs a scheduled task
        /// </summary>
        /// <param name="task">
        /// The invoked task
        /// </param>
        /// <remarks>
        /// This method is called when a periodic or resource intensive task is invoked
        /// </remarks>
        protected override void OnInvoke(ScheduledTask task)
        {
            //TODO: Add code to perform your task in background

            //TODO: https://tech.yandex.com/metrica-mobile-sdk/doc/mobile-sdk-dg/tasks/winphone-quickstart-docpage/-->
            YandexMetrica.Config.LocationTracking = false;
            YandexMetrica.Activate("Yours Api Key");
            YandexMetrica.ReportEvent("Hello from background!");
            YandexMetrica.Snapshot();
            NotifyComplete();
        }
    }
}
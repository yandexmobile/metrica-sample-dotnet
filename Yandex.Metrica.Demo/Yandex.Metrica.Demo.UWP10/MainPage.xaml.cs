using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Windows.ApplicationModel.Background;
using Yandex.Metrica;

namespace AppMetrica.Demo
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }
    }

    public static class JsonData
    {
        private static readonly Random Random = new Random(DateTime.Now.Millisecond);

        public static Person GetObject()
        {
            return new Person
            {
                FirstName = "ABC_" + Random.Next(),
                LastName = "XYZ_" + Random.Next()
            };
        }

        public static Dictionary<string, object> GetDictionary()
        {
            return new Dictionary<string, object>
            {
                {"Key1", "Value" + Random.Next()},
                {"Key2", "Value" + Random.Next()}
            };
        }
    }

    public partial class MainPage
    {
        public MainPage()
        {
            Location = new YandexMetrica.Location();
            InitializeComponent();

            //Loaded += (sender, args) => YandexMetrica.ReportEvent("Hello!");
            //Unloaded += (sender, args) => YandexMetrica.ReportEvent("Bye!");

            LocationButton.Click += (sender, args) => YandexMetricaConfig.SetCustomLocation(Location);
            EventButton.Click += (sender, args) => YandexMetrica.ReportEvent(EventNameTextBox.Text);
            CrashButton.Click += (sender, args) => { throw new Exception(); };
            ErrorButton.Click += (sender, args) =>
            {
                try
                {
                    throw new ArgumentException("Throw exception and catch it");
                }
                catch (Exception exception)
                {
                    YandexMetrica.ReportError(ErrorNameTextBox.Text, exception);
                }
            };

            ResetButton.Click += (sender, args) =>
            {
                YandexMetricaConfig.OfflineMode = false;
                YandexMetricaConfig.CrashTracking = true;
                YandexMetricaConfig.LocationTracking = true;
                YandexMetricaConfig.CustomAppVersion = null;
                YandexMetricaConfig.SetCustomLocation(null);
            };

            JsonButton.Click += (sender, args) => YandexMetrica.ReportEvent("abc", JsonData.GetObject());
            JsonButton.Click += (sender, args) => YandexMetrica.ReportEvent("abc", JsonData.GetDictionary());

            TaskButton.Click += async (sender, args) => await _trigger.RequestAsync();
            PrepareTask();
        }

        public YandexMetrica.Location Location { get; set; }

        public Yandex.Metrica.Models.Config YandexMetricaConfig => YandexMetrica.Config;

        private readonly ApplicationTrigger _trigger = new ApplicationTrigger();

        private void PrepareTask()
        {
            var taskName = "AppTask";
            BackgroundTaskRegistration.AllTasks.Values.FirstOrDefault(t=>t.Name == taskName)?.Unregister(true);
            var taskBuilder = new BackgroundTaskBuilder {TaskEntryPoint = "AppMetricaTask.AppTask", Name = taskName};
            taskBuilder.SetTrigger(_trigger);
            taskBuilder.Register();
        }
    }
}
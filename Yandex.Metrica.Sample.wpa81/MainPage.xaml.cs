using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Yandex.Metrica.Sample.wpa81
{
    /// <summary>
    /// Report sample application events.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            YandexMetrica.ReportEvent("MainPage Ctor");

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnUnloaded(object sender, RoutedEventArgs routedEventArgs)
        {
            YandexMetrica.ReportEvent("MainPage Unloaded");
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            YandexMetrica.ReportEvent("MainPage Loaded");
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            YandexMetrica.ReportEvent("Button click");
        }

        private void OnError(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new ArgumentException("Throw exception and catch it'");
            }
            catch (Exception ex)
            {
                YandexMetrica.ReportError("Main button error", ex);
            }
        }

        private void OnCrash(object sender, RoutedEventArgs e)
        {
            throw new ArgumentException();
        }
    }
}

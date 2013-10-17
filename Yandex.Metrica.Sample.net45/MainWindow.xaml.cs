using System;
using System.Windows;

namespace Yandex.Metrica.Sample
{
    /// <summary>
    /// Report sample application events.
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Counter.ReportEvent("MainPage Ctor");
            Counter.DispatchPeriod = TimeSpan.FromSeconds(5);

            Loaded += OnLoaded;
            Unloaded += OnUnloaded;
        }

        private void OnUnloaded(object sender, RoutedEventArgs routedEventArgs)
        {
            Counter.ReportEvent("MainPage Unloaded");
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            Counter.ReportEvent("MainPage Loaded");
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            Counter.ReportEvent("Button click");
        }

        private void OnError(object sender, RoutedEventArgs e)
        {
            try
            {
                throw new ArgumentException("Throw exception and catch it'");
            }
            catch (Exception ex)
            {
                Counter.ReportError("Main button error", ex);
            }
        }

        private void OnCrash(object sender, RoutedEventArgs e)
        {
            throw new ArgumentException();
        }
    }
}

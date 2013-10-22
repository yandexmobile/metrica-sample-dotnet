using System;
using System.Windows.Forms;

namespace Yandex.Metrica.Sample.net45.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Counter.ReportEvent("Form1 Loaded");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Counter.ReportEvent("Form1 Loaded");
        }

        private void Button1Click(object sender, EventArgs e)
        {
            Counter.ReportEvent("Button click");
        }

        private void Button2Click(object sender, EventArgs e)
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

        private void Button3Click(object sender, EventArgs e)
        {
            throw new ArgumentException();
        }
    }
}

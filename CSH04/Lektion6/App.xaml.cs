using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace Lektion6
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Debug.WriteLine("App OnStartup");
            base.OnStartup(e);
        }
        protected override void OnActivated(EventArgs e)
        {
            Debug.WriteLine("App OnACtivated");
            base.OnActivated(e);
        }
        protected override void OnDeactivated(EventArgs e)
        {
            Debug.WriteLine("App OnDeactivated");
            base.OnDeactivated(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            Debug.WriteLine("App OnExit");
            MessageBox.Show("WPF beendet");
            base.OnExit(e);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lektion6_1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonÜbernehmen_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEingabe.Text.Length >0)
            {
                listBoxStichpunkte.Items.Add(textBoxEingabe.Text);
                textBoxEingabe.Text = "";
                textBoxEingabe.Focus();
            }
            else
            {
                
            }
        }

        private void buttonBeenden_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

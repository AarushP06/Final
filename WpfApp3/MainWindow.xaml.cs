using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Exercise3 : Page
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void EngineCheck_Click(object sender, RoutedEventArgs e)
        {
            if (EngineCheck.IsChecked == true)
            {
                EngineCheck.Content = "Engine On";

                AudioCheck.IsEnabled = true;
                WipersCheck.IsEnabled = true;
                ACCheck.IsEnabled = true;

                AudioCheck.IsChecked = true;
                WipersCheck.IsChecked = true;
                ACCheck.IsChecked = true;
            }
            else if (EngineCheck.IsChecked == null)
            {
                EngineCheck.Content = "Ignition";

                AudioCheck.IsEnabled = true;
                WipersCheck.IsEnabled = true;
                ACCheck.IsEnabled = false;

                AudioCheck.IsChecked = true;
                WipersCheck.IsChecked = true;
                ACCheck.IsChecked = false;
            }
            else
            {
                EngineCheck.Content = "Engine Off";

                AudioCheck.IsEnabled = false;
                WipersCheck.IsEnabled = false;
                ACCheck.IsEnabled = false;

                AudioCheck.IsChecked = false;
                WipersCheck.IsChecked = false;
                ACCheck.IsChecked = false;
            }
        }
    }
}

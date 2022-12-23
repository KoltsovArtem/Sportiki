using System.Windows;

namespace WpfApplication1.Windows
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void StartProtocols_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResultProtocols_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GroupsResultProtocols_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoToStart_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainW = new MainWindow();
            mainW.Show();
            this.Close();
        }
    }
}
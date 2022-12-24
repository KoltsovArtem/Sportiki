using System.Windows;

namespace WpfApplication1.Windows
{
    public partial class MenuWindow : Window
    {
        int i = 0;
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void StartProtocols_Click(object sender, RoutedEventArgs e)
        {
            StartProtocolsLabel.Content = "Стартовые протколы сформированы";
            StartProtocols.Visibility = Visibility.Collapsed;
            if (i == 2) SeeResults.Visibility = Visibility.Visible;
            else i += 1;
        }

        private void ResultProtocols_Click(object sender, RoutedEventArgs e)
        {
            ResultProtocolsLabel.Content = "Протоколы результатов сформированы";
            ResultProtocols.Visibility = Visibility.Collapsed;
            if (i == 2) SeeResults.Visibility = Visibility.Visible;
            else i += 1;
        }

        private void GroupsResultProtocols_Click(object sender, RoutedEventArgs e)
        {
            GroupsResultProtocolsLabel.Content = "Протоколы результатов команд сформированы";
            GroupsResultProtocols.Visibility = Visibility.Collapsed;
            if (i == 2) SeeResults.Visibility = Visibility.Visible;
            else i += 1;
        }

        private void BackUp_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainW = new MainWindow();
            mainW.Show();
            this.Close();
        }

        private void SeeResults_Click(object sender, RoutedEventArgs e)
        {
            ResultsWindow res = new ResultsWindow();
            res.Show();
            this.Close();
        }
    }
}
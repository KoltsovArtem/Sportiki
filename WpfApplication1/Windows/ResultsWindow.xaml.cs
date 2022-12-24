using System.Windows;
using System.Windows.Controls;
using WpfApplication1.Pages;

namespace WpfApplication1.Windows
{
    public partial class ResultsWindow : Window
    {
        int i = 0; 

        public ResultsWindow()
        {
            InitializeComponent();
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                GridMain.Margin = new Thickness(200, 60, 10, 10);
                textOrganiz.Margin = new Thickness(200, 0, 0, 0);
                Panel.Margin = new Thickness(0, 0, 835, 0);
                i = 1;
            }
            else
            {
                GridMain.Margin = new Thickness(60, 60, 10, 10);
                textOrganiz.Margin = new Thickness(60, 0, 0, 0);
                Panel.Margin = new Thickness(0, 0, 975, 0);
                i = 0;
            }
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemSportsmans":
                    GridMain.Navigate(new Cheto());
                    break;
                case "ItemCommand":
                    //GridMain.Navigate(new TeamsPage());
                    break;
                case "ItemMyCommand":
                    //GridMain.Navigate(new MyCommandPage());
                    break;
                case "ItemCompetition":
                    //GridMain.Navigate(new CompetitionsPage());
                    break;
                case "ItemResult":
                    //GridMain.Navigate(new ResultCompetitionsPage());
                    break;
                case "ItemReports":
                    //GridMain.Navigate(new ReportPage());
                    break;
                default:
                    break;
            }
        }
    }
}
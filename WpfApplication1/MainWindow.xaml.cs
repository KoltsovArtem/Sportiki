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
using System.Windows.Shapes;
using WpfApplication1.Pages;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            GridMain.Navigate(new MainPage());
        }
        
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            GridMain.Margin = new Thickness(210, 60, 0, 0);
            textOrganiz.Margin = new Thickness(280, 0, 0, 0);
        }
        
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
            GridMain.Margin = new Thickness(70, 60, 0, 0);
            textOrganiz.Margin = new Thickness(100, 0, 0, 0);
        }
        
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    GridMain.Navigate(new MainPage());
                    break;
                /*case "ItemSportsmans":
                    GridMain.Navigate(new SportsmansPage());
                    break;
                case "ItemTrainers":
                    GridMain.Navigate(new TrainersPage());
                    break;
                case "ItemCommand":
                    GridMain.Navigate(new TeamsPage());
                    break;
                case "ItemMyCommand":
                    GridMain.Navigate(new MyCommandPage());
                    break;
                case "ItemCompetition":
                    GridMain.Navigate(new CompetitionsPage());
                    break;
                case "ItemPartipication":
                    GridMain.Navigate(new MyRequestsPage());
                    break;
                case "ItemResult":
                    GridMain.Navigate(new ResultCompetitionsPage());
                    break;
                case "ItemScore":
                    GridMain.Navigate(new TotalPersonalScoresPage());
                    break;
                case "ItemReports":
                    GridMain.Navigate(new ReportPage());
                    break;*/
                default:
                    break;
            }
        }
    }
}
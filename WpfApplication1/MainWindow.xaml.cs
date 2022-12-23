using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
        int k = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Applications_Click(object sender, RoutedEventArgs e)
        {
            ApplicationsLabel.Content = "Заявочные списки загружены успешно";
            Applications.Visibility = Visibility.Collapsed;
            k += 1;
        }

        private void Checkpoints_Click(object sender, RoutedEventArgs e)
        {
            CheckpointsLabel.Content = "Чекпоинты загружены успешно";
            Checkpoints.Visibility = Visibility.Collapsed;
            k += 1;
        }

        private void Groups_Click(object sender, RoutedEventArgs e)
        {
            GroupsLabel.Content = "Группы загружены успешно";
            Groups.Visibility = Visibility.Collapsed;
            k += 1;
        }

        private void Routes_Click(object sender, RoutedEventArgs e)
        {
            RoutesLabel.Content = "Маршруты загружены успешно";
            Routes.Visibility = Visibility.Collapsed;
            k += 1;
        }

        private void ProtCheck_Click(object sender, RoutedEventArgs e)
        {
            ProtCheckLabel.Content = "Протоколы чекпоинтов загружены успешно";
            ProtCheck.Visibility = Visibility.Collapsed;
            k += 1;
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            if (k != 5)
            {
                MessageBox.Show("Вы должны загрузить все файлы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        /*private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
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
                    break;#1#
                default:
                    break;
            }
        }*/
    }
}
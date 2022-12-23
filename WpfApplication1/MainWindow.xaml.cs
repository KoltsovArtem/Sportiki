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
using WpfApplication1.Windows;

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
                MessageBox.Show("Вы должны загрузить все файлы", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MenuWindow menu = new MenuWindow();
                menu.Show();
                this.Close();
            }
        }
    }
}
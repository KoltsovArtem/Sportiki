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
using System.IO;
using CsvHelper;
using System.Collections;
using System.Globalization;
using System.Text;
using CsvHelper.Configuration;
using WpfApplication1.Classes;
using Excel = Microsoft.Office.Interop.Excel;

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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                MessageBox.Show(openFileDialog.FileName);

                var pathCsvFile = openFileDialog.FileName;
                MessageBox.Show(pathCsvFile);

                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.UTF8, // Файл использует кодировку UTF-8
                    Delimiter = "," // Разделитель - запятая
                };

                using (var fs = File.Open(pathCsvFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (var textReader = new StreamReader(fs, Encoding.UTF8))
                    using (var csv = new CsvReader(textReader, configuration))
                    {
                        csv.Read();

                        var data = csv.GetRecords<personApplication>().ToHashSet();
                        foreach (var person in data)
                        {
                            csv.Read();
                        }
                    }

                }
            }
            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == true)
            {
                //var pathCsvFile1 = File.Create(pathStart);
                var path = Dialog.FileName;

                var pathCsvFile1 = File.Create(path);
                pathCsvFile1.Close();


                // добавляем тестовые данные, которые будем записывать в csv файл

                List<startList> startLists = new List<startList>

                {
                    new startList() { 
                        Группа = "Б-09", Фамилия = "Якубова", Имя = "Ксения",Номер = 1},

                    new startList() { 
                        Группа = "Б-09", Фамилия = "Кольцов", Имя = "Артем",Номер = 2},

                    new startList() { 
                        Группа = "Б-09", Фамилия = "Гвоздь", Имя = "Дмитрий",Номер = 3}


                };
                
                var configuration1 = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.UTF8, // Файл использует кодировку UTF-8
                    Delimiter = "," // Разделитель - запятая
                };

                using (var fs1 = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.Write))
                {
                    using (var textWriter = new StreamWriter(fs1, Encoding.UTF8))
                    using (var csv1 = new CsvWriter(textWriter, configuration1))
                    {
                        csv1.WriteRecords(startLists);
                    }

                }
                pathCsvFile1.Close();
            }
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
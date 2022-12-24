using System.Windows;

namespace WpfApplication1.Windows
{
    public partial class ResultsWindow : Window
    {
        int i = 0; 
        private void Open()
        {

        }

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
    }
}
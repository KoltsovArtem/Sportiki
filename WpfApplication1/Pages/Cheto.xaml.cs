using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1.Pages
{
    public partial class Cheto : Page
    {
        public Cheto()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
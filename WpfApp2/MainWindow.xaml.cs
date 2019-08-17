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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TodayBtnClicked(object sender, RoutedEventArgs e)
        {
            mainDrawer.IsLeftDrawerOpen = false;
            todayRadion.IsChecked = true;
            monthRadio.IsChecked = false;
            weekRadio.IsChecked = false;
        }

        private void WeekBtnClicked(object sender, RoutedEventArgs e)
        {
            mainDrawer.IsLeftDrawerOpen = false;
            todayRadion.IsChecked = false;
            monthRadio.IsChecked = true;
            weekRadio.IsChecked = false;

        }

        private void MounthBtnClicked(object sender, RoutedEventArgs e)
        {
            mainDrawer.IsLeftDrawerOpen = false;
            todayRadion.IsChecked = false;
            monthRadio.IsChecked = false;
            weekRadio.IsChecked = true;

        }
    }
}

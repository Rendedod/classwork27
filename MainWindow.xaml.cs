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

namespace WPF27._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime? selectedDate1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cal1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedDate1 = cal1.SelectedDate;
            dp1.SelectedDate = selectedDate1;
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            cal2.DisplayDateStart = dp2.SelectedDate;
            cal2.DisplayDateEnd = dp22.SelectedDate;
        }
    }
}

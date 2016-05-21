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

namespace Timetable_Manager
{
    /// <summary>
    /// Логика взаимодействия для ChangeDate.xaml
    /// </summary>
    public partial class ChangeDate : Window
    {
        public ChangeDate()
        {
            InitializeComponent();
        }

        private void btn_ChangeDate_Click(object sender, RoutedEventArgs e)
        {
            if (changeDate_Calendar.SelectedDate != null)
            {
                MainWindow.dt = changeDate_Calendar.SelectedDate;
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

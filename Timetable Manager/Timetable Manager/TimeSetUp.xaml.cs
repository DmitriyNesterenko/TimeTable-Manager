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
    public sealed class LessonTime
    {
        public TimeSpan windowTimeSetUp { get; set; }
        public DateTime? dateForLesson { get; set; }

        public LessonTime()
        {
            dateForLesson = DateTime.Now;
        }
    }

    public partial class TimeSetUp : Window
    {
        private static TimeSetUp windowTimeSetUp = null;
        private static LessonTime lessonTime;

        public static LessonTime SetTime()
        {
            windowTimeSetUp = new TimeSetUp();
            windowTimeSetUp.ShowDialog();

            return lessonTime;
        }

        public TimeSetUp()
        {
            InitializeComponent();
            lessonTime = new LessonTime();
        }

        private void btn_GreatNumber_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Number = int.Parse(txt_Number.Text);
                Number += 5;

                if (Number > 60)
                {
                    txt_Number.Text = "60";
                }
                else
                {
                    txt_Number.Text = Number.ToString();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Less_Number_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Number = int.Parse(txt_Number.Text);
                Number -= 5;

                if (Number < 5)
                {
                    txt_Number.Text = "5";
                }
                else
                {
                    txt_Number.Text = Number.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_Accept_Click(object sender, RoutedEventArgs e)
        {
            int Number = int.Parse(txt_Number.Text);
            lessonTime.windowTimeSetUp = new TimeSpan(0, Number, 0);
            lessonTime.dateForLesson = calendarDate.SelectedDate;
            windowTimeSetUp.Close();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            lessonTime.windowTimeSetUp = new TimeSpan(0, 0, 0);
            windowTimeSetUp.Close();
        }

        private void calendarDate_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            lessonTime.dateForLesson = calendarDate.SelectedDate;
            this.Title = "Time Set Up: " + lessonTime.dateForLesson.ToString();

            if (lessonTime.dateForLesson.Value.Year < DateTime.Now.Year || (lessonTime.dateForLesson.Value.Month < DateTime.Now.Month && lessonTime.dateForLesson.Value.Day < DateTime.Now.Day && lessonTime.dateForLesson.Value.Year == DateTime.Now.Year)
                || (lessonTime.dateForLesson.Value.Day < DateTime.Now.Day && lessonTime.dateForLesson.Value.Month == DateTime.Now.Month && lessonTime.dateForLesson.Value.Year == DateTime.Now.Year))
                btn_Accept.IsEnabled = false;
            else
                btn_Accept.IsEnabled = true;
        }
    }
}

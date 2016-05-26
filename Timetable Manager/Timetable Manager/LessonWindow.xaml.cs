using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Data.SqlClient;

namespace Timetable_Manager
{
    /// <summary>
    /// Логика взаимодействия для LessonWindow.xaml
    /// </summary>
    public partial class LessonWindow : Window
    {
        private int time = default(int);
        private DispatcherTimer timer;
        private MyLesson currentLesson;

        public LessonWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
        }

        // Устанавливает время, которое потребуется на выполнение учебного модуля.
        private void SetUpTimer()
        {
            time = currentLesson.TimeRest.Minutes * 60 + currentLesson.TimeRest.Seconds;
        }

        public LessonWindow(MyLesson myLesson)
            : this()
        {
            #region Initialize My Current Lesson

            currentLesson = myLesson;
            TBLessonName.Text = currentLesson.Name;
            txtBox_Comments.Text = currentLesson.Comments.ToString();

            this.SetUpTimer();

            #endregion

            #region Set up the view

            if (time > (540 + 59))
            {
                TBCountDown.Text = string.Format("00:{0}:{1}", time / 60, time % 60);
            }
            else if (time >= 10)
            {
                TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
            }
            else
            {
                TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
            }

            #endregion
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //currentLesson.TimeRest = new TimeSpan(0, time / 60, time % 60);
            if (time > 0)
            {
                if (time <= 10)
                {
                    if(time%2 == 0)
                    {
                        TBCountDown.Foreground = Brushes.Red;
                    }
                    else
                    {
                        TBCountDown.Foreground = Brushes.Gray;
                    }
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
                }
                else if (time > (540 + 59))
                {
                    time--;
                    TBCountDown.Text = string.Format("00:{0}:{1}", time / 60, time % 60);
                }
                else
                {
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
                }
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Your time has been finished");
            }
        }

        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void btn_Pause_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            ResetTimer();
        }

        private void ResetTimer()
        {
            this.SetUpTimer();
            currentLesson.TimeRest = new TimeSpan(0, time / 60, time % 60);
            if (time > (540 + 59))
            {
                TBCountDown.Text = string.Format("00:{0}:{1}", time / 60, time % 60);
            }
            else if (time >= 10 && time <= (540 + 59))
            {
                TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
            }
            else
            {
                TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
            }
        }

        //Обновляет базу данных: оставшееся время урока.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            timer.Stop();
            SqlConnection connection = new SqlConnection(MainWindow.connectionString);
            currentLesson.TimeRest = new TimeSpan(0, time / 60, time % 60);

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                String query = "UPDATE Item SET Time='" + currentLesson.TimeRest.ToString() + "' WHERE Id=" + currentLesson.Id.ToString() + ";";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();


            }
            catch(SqlException exc)
            {
                MessageBox.Show(exc.Message, "SQL-Error was happened when window closing");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error was happened when window closing");
            }
        }
    }
}

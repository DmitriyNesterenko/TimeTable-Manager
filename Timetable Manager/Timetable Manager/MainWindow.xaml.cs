using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading;
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
using System.Data.SqlClient;
using System.Windows.Threading;

namespace Timetable_Manager
{
    public partial class MainWindow : Window
    {
        #region Declare Variables

        private Char[] trimChars = new Char[20] { '.', ',', '/', ':', ' ', '!', '@', '%', '^', '&', '*', '(', ')', '{', '}', '"', '|', '\\', ';', '$' };
        private String pathExportFile = String.Empty;
        private Int16 maxId;

        public SqlConnection connection;
        public List<MyLesson> list = new List<MyLesson>();
        public static String connectionString = @"Data Source = (local)\SQLEXPRESS;
            Initial Catalog = TimeTable; Integrated Security = True";

        public static DateTime? dt;

        #endregion

        private Int16 GetMaxIdFromDatabase()
        {
            Int16 templateMaxId = default(Int16);

            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                String query = "SELECT Id FROM Item";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Int16> listOfId = new List<Int16>();
                while (reader.Read())
                {
                    listOfId.Add(Int16.Parse(reader["Id"].ToString()));
                }

                if (listOfId.Count > 0)
                {
                    listOfId.Sort();
                    templateMaxId = listOfId[listOfId.Count - 1];
                }
                else
                {
                    templateMaxId = 0;
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "The App generate error when try to get maxId");
            }

            return templateMaxId;
        }

        // Update database. This function delete all records, 
        // that have date less than today.
        private void DateCheck()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Item WHERE Date < @DATE";
                DateTime dt = DateTime.Now;
                SqlParameter parametr = new SqlParameter();
                parametr.ParameterName = "@DATE";
                parametr.SqlDbType = SqlDbType.Date;
                parametr.Value = dt.Day.ToString() + "." + dt.Month.ToString() + "." + dt.Year.ToString();
                command.Parameters.Add(parametr);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error. Exception from DateCheck Function");
                App.Current.Shutdown();
            }
        }

        // Load today lessons to listView.
        private void LoadData()
        {
            try
            {
                list.Clear();
                ListItem.Items.Clear();
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                //Получаем нужную дату, для правильного отображения ListItem.

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT Item, Time, Id FROM Item WHERE Date=@DATE";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@DATE";
                parameter.SqlDbType = SqlDbType.Date;
                parameter.Value = string.Format($"{dt.Value.Day}.{dt.Value.Month}.{dt.Value.Year}");
                command.Parameters.Add(parameter);
                
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    string[] str = reader["Time"].ToString().Split(new char[] { ':', '.', '/' }, StringSplitOptions.RemoveEmptyEntries);
                    int hours = int.Parse(str[0]);
                    int minutes = int.Parse(str[1].ToString());
                    int seconds = int.Parse(str[2].ToString());

                    MyLesson newItem = new MyLesson() { Name = reader["Item"].ToString(), TimeRest = new TimeSpan(hours, minutes, seconds), Id = reader[2].ToString() };
                    ListItem.Items.Add(newItem);
                    list.Add(newItem);
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Loading data error");
            }
        }

        // Function that initialize all data.
        public MainWindow()
        {
            InitializeComponent();
            list.Clear();
            connection = new SqlConnection(connectionString);
            DateCheck();
            LoadData();
            maxId = GetMaxIdFromDatabase();
        }

        //Individual event that update date time in the app.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt = DateTime.Now;
            lbl_date.Content = "Today: " + dt.Value.Day.ToString() + "." + dt.Value.Month.ToString() + "." + dt.Value.Year.ToString();
        }

        //This event AddItem to listView and add it to the database of the app.
        private void btn_AddLesson_Click(object sender, RoutedEventArgs e)
        {
            maxId++;
            String itemStr = txtBox_Item.Text.Trim(trimChars);
            MyLesson newItem = new MyLesson() { Id = maxId.ToString(), Name = itemStr };

            #region Настройка времени модуля

            LessonTime lessonTime = TimeSetUp.SetTime();
            newItem.TimeRest = lessonTime.windowTimeSetUp;
            dt = lessonTime.dateForLesson;
            if (newItem.TimeRest.Minutes == 0 && newItem.TimeRest.Hours == 0)
                return;

            #endregion

            ListItem.Items.Add(newItem);
            list.Add(newItem);
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                String TimeRest = newItem.TimeRest.ToString();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO Item (Id, Item, Time, Date) VALUES ({int.Parse(newItem.Id)}, '{itemStr}', '{TimeRest}', @Date);";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Date";
                parameter.SqlDbType = SqlDbType.Date;
                parameter.Value = dt.Value.Day.ToString() + "/" + dt.Value.Month.ToString() + "/" + dt.Value.Year.ToString();

                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();

                command.Dispose();
                txtBox_Item.Text = string.Empty;

                //Обновить ListItem.
                LoadData();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }

        //Export our timetable to *.txt file on the HDD.
        private void menuBtn_Export_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pathExportFile = ofd.FileName;
                    using (StreamWriter sw = new StreamWriter(pathExportFile))
                    {
                        for (int i = 0; i < list.Count; i++)
                            sw.WriteLine(list[i].ToString());
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //Correct Exit from the app.
        private void menuBtn_Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        //Delete item from database by using listview.
        private void ListItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("You are about to delete item. Are you sure?", "Caption", MessageBoxButton.YesNo))
            {
                MyLesson deletedItem = (MyLesson)ListItem.SelectedItem;

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Item WHERE Id=" + deletedItem.Id + ";";
                    command.ExecuteNonQuery();

                    LoadData();

                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        //Button that show all main information about the app.
        private void menuBtn_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Authors: Dmitriy Nesterenko (NesterenkoDmitry96@gmail.com)" + Environment.NewLine +
                "Anatoliy Rozhko (anatolyrozk@gmail.com)" + Environment.NewLine +
                "Version: Build 0004");
        }

        //Начать работу с уроком. Открывается окно по работе с уроком.
        private void ListItem_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (MessageBoxResult.Yes == MessageBox.Show("You are about to start lesson. Are you sure?", "Caption", MessageBoxButton.YesNo))
            {
                try
                {
                    MyLesson selectedItem = (MyLesson)ListItem.SelectedItem;
                    LessonWindow lessonWindow = new LessonWindow(selectedItem);
                    lessonWindow.ShowDialog();
                    LoadData();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        //Меняем дату отображения списка.
        private void menuBtn_ChangeDate_Click(object sender, RoutedEventArgs e)
        {
            ChangeDate changeDate = new ChangeDate();
            changeDate.ShowDialog();
            LoadData();
        }
    }
}
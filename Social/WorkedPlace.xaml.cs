using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
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
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.Win32;

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для WorkedPlace.xaml
    /// </summary>
    public partial class WorkedPlace : Page
    {
        public WorkedPlace()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            AdminPanel.Navigate(new Uri("http://localhost/shopping/admin/"));
            AdminPanel.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void filexplorer_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void filexplorer_Navigated_1(object sender, NavigationEventArgs e)
        {

        }

        private void avplayerfrm_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VideoWindow VideoWindow = new VideoWindow();
            VideoWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Adobe\\Adobe Photoshop 2020\\Photoshop.exe");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var fo = new OpenFileDialog();

            fo.Multiselect = true;
            fo.Filter = "All Media Files|*.exe";

            var result = fo.ShowDialog();
            //file = fo.FileName;

        }

        private void AdminPanel_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void AdminPanel_LoadCompleted(object sender, NavigationEventArgs e)
        {
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Sony\\Vegas Pro 13\\vegas130.exe");
        }

        private void mysearchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //DEVELOPE SEARCH


            //MainViewModel Source = new MainViewModel();
            //string connectionString = "Server=localhost;Database=shopping;Uid=root;Pwd= ;";
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //string query = "SELECT * FROM products WHERE productName LIKE '%" + mysearchbox.Text + "%'";
            //try
            //{
            //    connection.Open();
            //    MySqlCommand command = new MySqlCommand(query, connection);
            //    MySqlDataReader reader = command.ExecuteReader();

            //    //Katalog.ClearValue(ItemsControl.ItemsSourceProperty);
                

            //    while (reader.Read())
            //    {
            //        Katalog.Items.Add(reader["productName"].ToString());
            //    }

            //    reader.Close();
            //    command.Dispose();
            //    connection.Close();
            //}
            //catch (MySqlException ex)
            //{
            //    Console.WriteLine("Error: " + ex.ToString());
            //}

        }

        private void Katalog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AdminPanel.Navigate(new Order());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AdminPanel.Navigate(new Uri("http://localhost/shopping/admin/"));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AdminPanel.Navigate(new Users());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AdminPanel.Navigate(new admins());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Adobe\\Adobe After Effects CC 2018\\Support Files\\AfterFX.exe");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Disk D\\Worked folder\\Adobe AI\\Adobe Illustrator 2020\\Support Files\\Contents\\Windows\\Illustrator.exe");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\\Disk D\\Steam\\steamapps\\common\\Blender\\blender.exe");
        }
    }
}

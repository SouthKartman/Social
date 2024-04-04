using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.IO;

namespace Social.MySpace.menus
{
    /// <summary>
    /// Логика взаимодействия для BDMenus.xaml
    /// </summary>
    public partial class BDMenus : Page
    {
        string sSelectedFile;
        public BDMenus()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://localhost/phpmyadmin/index.php?route=/");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://akttservice.ru/index.php?do=mysql&manage=user");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\msSQLroot.txt";
                string wpfAppPath = File.ReadAllText(pathToFile);
                Process.Start(wpfAppPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выбирите путь к приложению...");

                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;
                //choofdlog.Multiselect = true;

                if (choofdlog.ShowDialog() == true)
                {
                    string sFileName = choofdlog.FileName;
                    //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                    //MessageBox.Show("Выбран файл: " + choofdlog.FileName);
                    sSelectedFile = choofdlog.FileName;
                    MessageBox.Show("Выбран файл: " + sSelectedFile);
                    string folderPath = @"C:\ProgramData\SocialHelper\logs\roots"; // Укажите путь к новой папке


                    // Проверяем, существует ли папка
                    if (!Directory.Exists(folderPath))
                    {
                        // Создаем папку
                        Directory.CreateDirectory(folderPath);
                        //MessageBox.Show("Папка успешно создана.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        //MessageBox.Show("Папка уже существует", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\msSQLroot.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}


            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\MONGOroot.txt";
                string wpfAppPath = File.ReadAllText(pathToFile);
                Process.Start(wpfAppPath);
                Process.Start("https://www.mongodb.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Выбирите путь к приложению...");

                OpenFileDialog choofdlog = new OpenFileDialog();
                choofdlog.Filter = "All Files (*.*)|*.*";
                choofdlog.FilterIndex = 1;
                //choofdlog.Multiselect = true;

                if (choofdlog.ShowDialog() == true)
                {
                    string sFileName = choofdlog.FileName;
                    //string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true
                    //MessageBox.Show("Выбран файл: " + choofdlog.FileName);
                    sSelectedFile = choofdlog.FileName;
                    MessageBox.Show("Выбран файл: " + sSelectedFile);
                    string folderPath = @"C:\ProgramData\SocialHelper\logs\roots"; // Укажите путь к новой папке


                    // Проверяем, существует ли папка
                    if (!Directory.Exists(folderPath))
                    {
                        // Создаем папку
                        Directory.CreateDirectory(folderPath);
                        //MessageBox.Show("Папка успешно создана.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        //MessageBox.Show("Папка уже существует", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\MONGOroot.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}


            }
           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Process.Start("https://console.firebase.google.com/?_gl=1*1xqzqyf*_ga*MTQ2OTYzMDg5NC4xNjg5MTE2NTkw*_ga_CW55HF8NVT*MTY4OTExNjU5MC4xLjAuMTY4OTExNjU5MC4wLjAuMA..&pli=1");
        }
    }
}

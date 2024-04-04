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
    /// Логика взаимодействия для ServersMenu.xaml
    /// </summary>
    public partial class ServersMenu : Page
    {
        string sSelectedFile;
        public ServersMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\XAMProot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\XAMProot.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\WAMProot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\WAMProot.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}


            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://akttservice.ru/index.php?do=filemanager#elf_l1_Lw");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\INSOMroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\INSOMroot.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}


            }
        }
    }
}

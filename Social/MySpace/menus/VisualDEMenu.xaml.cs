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
using Microsoft.Win32;

namespace Social.MySpace.menus
{
    /// <summary>
    /// Логика взаимодействия для VisualDEMenu.xaml
    /// </summary>
    public partial class VisualDEMenu : Page
    {
        string sSelectedFile;
        public VisualDEMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\VSroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\VSroot.txt", sSelectedFile);

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
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\VSCroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\VSCroot.txt", sSelectedFile);

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
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\PYCHroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\PYCHroot.txt", sSelectedFile);

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
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\ATOMroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\ATOMroot.txt", sSelectedFile);

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
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\NP++.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\NP++.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}


            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\KOALAroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\KOALAroot.txt", sSelectedFile);

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

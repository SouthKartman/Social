using Microsoft.Win32;
using Social.MySpace.menus;
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
using System.Windows.Shapes;
using System.IO;
using System.Windows.Threading;

namespace Social.MySpace
{
    /// <summary>
    /// Логика взаимодействия для NonPhixWindow.xaml
    /// </summary>
    /// 


    public partial class NonPhixWindow : Window
    {
          //переменные для обраблотки запросов к приложению
          string sSelectedFile;
          string sSelectedFolder;

          //Переменные для перетаскивания окна мышью
          private bool isDragging = false;
          private Point startPoint;

        public NonPhixWindow()
        {
            InitializeComponent();

            frmMain.Navigate(new HomeViewNonPhix());
            FrameLoad.MainFrame = frmMain;

            #region Часы
            // Создаем таймер, чтобы обновлять цифровое время каждую секунду
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            #endregion

        }



        #region Часы
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновляем цифровое время
            digitalClockText.Text = DateTime.Now.ToString("HH:mm");
        }
        #endregion

        #region Мышка и сварачивание

        //Сварачивание
        private void MinimizeButton_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        //Перенос
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            startPoint = e.GetPosition(this);
            this.CaptureMouse();
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            this.ReleaseMouseCapture();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = e.GetPosition(this);
                double diffX = currentPoint.X - startPoint.X;
                double diffY = currentPoint.Y - startPoint.Y;

                this.Left += diffX;
                this.Top += diffY;
            }
        }
        #endregion



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new HomeViewNonPhix());
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.ru/im");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            

            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\tgroot.txt";
                string wpfAppPath = File.ReadAllText(pathToFile);
                Process.Start(wpfAppPath);          
            }
            catch (Exception ex)
            {
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
                    
                    

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\tgroot.txt", sSelectedFile);

                }



                //FolderBrowserDialog fbd = new FolderBrowserDialog();
                //fbd.Description = "Custom Description";
                //if (fbd.ShowDialog() == DialogResult.OK)
                //{
                //    string sSelectedPath = fbd.SelectedPath;
                //}

                Process.Start("https://web.telegram.org/");
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frmMain.Navigate(new NonPhixWorkedPlace());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var response = MessageBox.Show("Вы точно хотите выйти?", "Выход...",
                                   MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (response == MessageBoxResult.No)
            {

            }
            else
            {
                Application.Current.Shutdown();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Gmail Gmail = new Gmail();
            Gmail.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }
    }
}

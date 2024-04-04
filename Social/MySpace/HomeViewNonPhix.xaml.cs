using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Social.MySpace
{
    /// <summary>
    /// Логика взаимодействия для HomeViewNonPhix.xaml
    /// </summary>
 
    
    public partial class HomeViewNonPhix : Page
    {
        string sSelectedFile;

        #region AnimationSlider

        private string[] imageFiles; // Массив с путями к вашим изображениям
        private int currentIndex = 0;
        private Storyboard fadeAnimationStoryboard; // Анимация затухания


        #endregion

        public HomeViewNonPhix()
        {
            InitializeComponent();

            #region Путь к изображениям
                // Загрузка изображений из указанной директории (путь к директории с фотографиями)
                string strDestopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string imageFolder = @"/Social";
               //string imageFolderPath = "C:\\Users\\Public\\Pictures\\Social";
                string imageFolderPath = strDestopPath + imageFolder;

                if (!Directory.Exists(imageFolderPath))
                {
                    // Создаем папку
                    Directory.CreateDirectory(imageFolderPath);
                    //MessageBox.Show("Папка успешно создана.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    //MessageBox.Show("Папка уже существует", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                imageFiles = System.IO.Directory.GetFiles(imageFolderPath, "*.jpg"); // При необходимости измените расширение изображений
            #endregion
            //// Инициализация анимации
            //fadeAnimationStoryboard = (Storyboard)this.Resources["FadeAnimationStoryboard"];
            //fadeAnimationStoryboard.Begin(image, true);

            //// Запускаем слайд-шоу
            ///
            StartSlideshowAsync();
            //StartAnimation();

        }

        #region AnimationSlider

        private async void StartSlideshowAsync()
        {
            try
            {
                 // Проверка наличия изображений
                if (imageFiles.Length == 0)
                    return;

                // Запуск слайд-шоу с фотографиями и анимацией заднего фона
                while (true)
                {
                    ShowNextImage();
                    await Task.Delay(100000); // Асинхронная задержка между слайдами (в миллисекундах)
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Нет изображений в папке по пути users/pictures/Social/ ");
            }
           
        }

        //private void StartAnimation()
        //{
        //    // Создание анимации для плавного изменения прозрачности заднего фона
        //    DoubleAnimation fadeAnimation = new DoubleAnimation
        //    {
        //        From = 1.0,
        //        To = 0.0,
        //        Duration = new Duration(TimeSpan.FromSeconds(0.8)), // Время затухания одного изображения
        //        AutoReverse = true,
        //        RepeatBehavior = RepeatBehavior.Forever // Повторять анимацию бесконечно
        //    };

        //    // Привязка анимации к заднему фону элемента Grid
        //    backgroundImageBrush.BeginAnimation(ImageBrush.OpacityProperty, fadeAnimation);
        //}

        //private void ShowNextImage()
        //{
        //    if (currentIndex >= imageFiles.Length)
        //    {
        //        currentIndex = 0;
        //    }

        //    string imagePath = imageFiles[currentIndex];
        //    BitmapImage image = new BitmapImage(new Uri(imagePath));
        //    backgroundImageBrush.ImageSource = image;

        //    currentIndex++;
        //}

        #endregion

        #region AnimationSlider v2.0
        //private async void StartSlideshowAsync()
        //{
        //    // Проверка наличия изображений
        //    if (imageFiles.Length == 0)
        //        return;

        //    // Запуск слайд-шоу с фотографиями
        //    while (true)
        //    {
        //        ShowNextImage();
        //        await Task.Delay(5000); // Асинхронная задержка между слайдами (в миллисекундах)
        //    }
        //}

        private void ShowNextImage()
        {
            if (currentIndex >= imageFiles.Length)
            {
                currentIndex = 0;
            }

            string imagePath = imageFiles[currentIndex];
            BitmapImage image = new BitmapImage(new Uri(imagePath));
            backgroundImageBrush.ImageSource = image;

            currentIndex++;
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("D:\\Projects\\Media\\Photoshop");

            }catch(Exception ex)
            {
                MessageBox.Show("Вставьте диск");
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://drive.google.com/drive/my-drive");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://disk.yandex.ru/client/disk");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/im");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
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

            }
        }

            private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            try
            {
                string pathToFile = @"C:\ProgramData\SocialHelper\logs\roots\phroot.txt";
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

                    File.WriteAllText(@"C:\ProgramData\SocialHelper\logs\roots\phroot.txt", sSelectedFile);

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

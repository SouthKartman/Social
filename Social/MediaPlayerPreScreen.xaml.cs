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

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для MediaPlayerPreScreen.xaml
    /// </summary>
    public partial class MediaPlayerPreScreen : Page
    {
        public MediaPlayerPreScreen()
        {
            InitializeComponent();
        }

        private void BtnOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files (*.mpg; *.mpeg; *.avi; *.mp4)| *.mpg; *.mpeg; *.avi; *.mp4";
            if (openFileDialog.ShowDialog() == true)
            {
                avPlayer.Source = new Uri(openFileDialog.FileName);
                avPlayer.Play();
            }
        }

        private void BtnPlay(object sender, RoutedEventArgs e)
        {
            //Process.Start("EMP.exe");
        }

        private void BtnPause(object sender, RoutedEventArgs e)
        {
            avPlayer.Pause();
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            avPlayer.Pause();
        }
    }
}

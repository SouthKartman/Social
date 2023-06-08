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

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для VideoWindow.xaml
    /// </summary>
    public partial class VideoWindow : Window
    {
        public VideoWindow()
        {
            InitializeComponent();

            avplayerfrm.Navigate(new MediaPlayerPreScreen());
            FrameLoad.MainFrame = avplayerfrm;
        }

        private void avplayerfrm_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }
    }
}

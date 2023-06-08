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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для Gallery.xaml
    /// </summary>
    public partial class Gallery : Page
    {
        public Gallery()
        {
            InitializeComponent();
            GalleryFrame.Navigate(new Uri("http://localhost/shopping/create-draggable-site/ready-html/index.html"));
            GalleryFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void GalleryFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}

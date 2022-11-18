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
    /// Логика взаимодействия для WorkedPlace.xaml
    /// </summary>
    public partial class WorkedPlace : Page
    {
        public WorkedPlace()
        {
            InitializeComponent();

            avplayerfrm.Navigate(new MediaPlayerPreScreen());
            FrameLoad.MainFrame = avplayerfrm;

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
    }
}

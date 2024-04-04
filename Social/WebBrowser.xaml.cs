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
using System.IO;
using Microsoft.Web.WebView2.Core;
using System.Xml.Linq;
using mshtml;


namespace Social
{
    /// <summary>
    /// Логика взаимодействия для WebBrowser.xaml
    /// </summary>
    public partial class WebBrowser : Page
    {
        public WebBrowser()
        {
            InitializeComponent();

            #region Инициализация WebView2

            //webview.NavigationStarting += WebView_NavigationStarting;
            //webview.NavigationCompleted += WebView_NavigationCompleted;

            //webview.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;


            webview.EnsureCoreWebView2Async(null);

            //Uri url1 = new Uri(Directory.GetCurrentDirectory() + "https://yandex.ru/pogoda");
            Uri url1 = new Uri("https://yandex.ru/pogoda");
            webview.Source = url1;

            #endregion
        }

        #region WebView2



        private async void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            try
            {
                // Выполнение кода JavaScript для изменения масштаба страницы на 150%
                await webview.CoreWebView2.ExecuteScriptAsync("document.body.style.zoom = '60%';");


            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Ошибка при изменении масштаба: " + ex.Message);
            }
        }

        

        //void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        //{
        //    String uri = args.Uri;
        //    //if (!uri.StartsWith("https://"))
        //    //{
        //    //    webview.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
        //    //    args.Cancel = true;
        //    //}
        //    webview.CoreWebView2.ExecuteScriptAsync("document.body.style.zoom = 0.2");
        //}

       

        #endregion

        private void updateSite_Click(object sender, RoutedEventArgs e)
        {
            string site = weathertext.Text;
            try
            {
                //AdminPanel.Navigate(new Uri(site));
                Uri url1 = new Uri(site);
                webview.Source = url1;
            }
            catch
            {
                MessageBox.Show("Неправильно введён адрес");
            }
        }
    }
}

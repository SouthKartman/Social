using Google.Apis.YouTube.v3.Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
using static System.Net.WebRequestMethods;

namespace Social
{
    /// <summary>
    /// Логика взаимодействия для Gmail.xaml
    /// </summary>
    public partial class Gmail : Window
    {
        public static string file;
        public Gmail()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                string letter = Letter.Text;
                string adress = Adress.Text;
                string text = Teext.Text;
                SmtpClient mySmtpClient = new SmtpClient("smtp.mail.ru");

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = true;
                mySmtpClient.EnableSsl = true;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential("testfortest1.01@mail.ru", "gTdTpz07TjHaKY7bqfgM");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("testfortest1.01@mail.ru", "PhotoGraph"); //откуда
                MailAddress to = new MailAddress(adress, "Вам"); //куда
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                // add ReplyTo
                MailAddress replyTo = new MailAddress("testfortest1.01@mail.ru"); // почта на ответ = откуда (обычно)
                myMail.ReplyToList.Add(replyTo);

                // set subject and encoding
                myMail.Subject = letter;
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = text;
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html 
                myMail.IsBodyHtml = true;


                //отправка Прилогающих файлов
                Attachment sandfile = new Attachment (file);
                Attachment sandfile1 = new Attachment(file);
                Attachment sandfile2 = new Attachment(file);
                Attachment sandfile3 = new Attachment(file);
                Attachment sandfile4 = new Attachment(file);
                Attachment sandfile5 = new Attachment(file);
                Attachment sandfile6 = new Attachment(file);
                Attachment sandfile7 = new Attachment(file);
               
                myMail.Attachments.Add (sandfile);
                myMail.Attachments.Add(sandfile1);
                myMail.Attachments.Add(sandfile2);
                myMail.Attachments.Add(sandfile3);
                myMail.Attachments.Add(sandfile4);
                myMail.Attachments.Add(sandfile5);
                myMail.Attachments.Add(sandfile6);
                myMail.Attachments.Add(sandfile7);






                mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void  Button_Click_1(object sender, RoutedEventArgs e)

        {

            var fo = new OpenFileDialog();
            
            fo.Multiselect = true;
            fo.Filter = "All Media Files|*.png;*.jpg;*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            
            var result = fo.ShowDialog();
            file = fo.FileName;


        }
    }
}

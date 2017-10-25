using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace B4.PE2.OmedMilat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimerPage : ContentPage
    {
        Stopwatch timer = new Stopwatch();
        public TimerPage()
        {
            InitializeComponent();
            
        }

        private async void btnStart_Clicked(object sender, EventArgs e)
        {
            
            timer.Start();
            while(timer.IsRunning == true)
            {
                lblTimer.Text = timer.Elapsed.ToString(@"m\:ss\.ff");
                await Task.Delay(5);
            }
        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            //timer.Stop();
            //var mail = new MailMessage();
            //var smtpServer = new SmtpClient("smtp.gmail.com", 587);
            //mail.From = new MailAddress("myEmailAddress@gmail.com");
            //mail.To.Add("anotherAddress@yahoo.com");
            //mail.Subject = subject;
            //mail.Body = body;
            //smtpServer.Credentials = new NetworkCredential("username", "pass");
            //smtpServer.UseDefaultCredentials = false;
            //smtpServer.EnableSsl = true;
            //smtpServer.Send(mail);
        }
    }
}
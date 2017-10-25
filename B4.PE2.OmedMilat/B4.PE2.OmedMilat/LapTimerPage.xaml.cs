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
    public partial class LapTimerPage : ContentPage
    {
        int counter = 0;
        Stopwatch timer = new Stopwatch();
        public LapTimerPage()
        {
            InitializeComponent();

        }

        private async void btnStart_Clicked(object sender, EventArgs e)
        {
            timer.Start();
            btnStart.IsEnabled = false;
            while (StackLeft.Children.Count > 0 )
            {
                StackLeft.Children.RemoveAt(StackLeft.Children.Count - 1);
            }
            while(StackRight.Children.Count > 0)
            {
                StackRight.Children.RemoveAt(StackRight.Children.Count - 1);
            }
            while (timer.IsRunning == true)
            {
                lblTimer.Text = timer.Elapsed.ToString(@"m\:ss\.ff");
                await Task.Delay(5);
            }

        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Reset();
            counter = 0;
            btnStart.IsEnabled = true;
            btnLap.IsEnabled = true;
        }

        private void btnLap_Clicked(object sender, EventArgs e)
        {
            if (timer.IsRunning == true)
            {
                counter++;
                var label = new Label()
                {
                    Text = $"{counter}. " + timer.Elapsed.ToString(@"m\:ss\.ff"),
                    FontSize = 22
                };
                if (counter <= 8)
                    StackLeft.Children.Add(label);
                if (counter > 8 && counter <= 16)
                    StackRight.Children.Add(label);
                else if (counter > 16)
                {
                    DisplayAlert("Vol", "Er is geen plaats meer om lap times bij te houden.", "Ok");
                    btnLap.IsEnabled = false;
                }
            }
            else
                DisplayAlert("Fout", "De timer moet bezig zijn om een lap time te bewaren.", "Ok");
        }
    }
}
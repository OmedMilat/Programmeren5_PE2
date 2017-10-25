using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE2.OmedMilat
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var welkebtn = ((Button)sender).Text;

            if (welkebtn == "Timer")
                await Navigation.PushAsync(new TimerPage());
            if (welkebtn == "Lap Timer")
                await Navigation.PushAsync(new LapTimerPage());
            if (welkebtn == "FeedBack")
                await Navigation.PushAsync(new FeedBackPage());
        }
    }
}

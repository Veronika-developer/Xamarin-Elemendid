using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamlElemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer : ContentPage
    {
        Button stopButton, startButton;
        Label timerLabel;
        bool alive = true;
        public Timer()
        {
            StackLayout stack = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#a2c2cf"),
                Padding = new Thickness(50,60,50,60)
            };
            timerLabel = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                FontSize = 32
            };

            stopButton = new Button
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "STOP",
                BackgroundColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            stopButton.Clicked += StopButton_Clicked;
            startButton = new Button
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "START",
                BackgroundColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button))
            };
            startButton.Clicked += StartButton_Clicked; ;

            stack.Children.Add(timerLabel);
            stack.Children.Add(stopButton);
            stack.Children.Add(startButton);
            Content = stack;
        }

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            if (alive == true)
            {
                alive = false;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
            else
            {
                alive = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);
            }
        }

        private void StopButton_Clicked(object sender, EventArgs e)
        {
            alive = false;
        }

        private bool OnTimerTick()
        {
            timerLabel.Text = DateTime.Now.ToString("T");
            return alive;
        }
    }
}
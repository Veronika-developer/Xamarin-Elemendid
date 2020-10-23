using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamlElemendid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }

        private async void webView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new webview());
        }

        private async void tableview_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new tableView());
        }

        private async void datapicker_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new datapicker());
        }

        private async void picker_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new picker());
        }

        private async void timepicker_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new timepicker());
        }

        private async void listview_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new listview());
        }
    }
}

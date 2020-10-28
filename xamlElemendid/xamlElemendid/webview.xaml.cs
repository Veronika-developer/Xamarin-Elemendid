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
    public partial class webview : ContentPage
    {
        WebView webView;
        Entry urlEntry;
        public webview()
        {
            urlEntry = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            Button button = new Button { Text = "Go", BackgroundColor = Color.Black, TextColor = Color.White };
            button.Clicked += Button_Clicked;
            StackLayout stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button, urlEntry }
            };
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = "http://google.com/" },
                // или так
                // Source = "http://blog.xamarin.com/",
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout { Children = { stack, webView } };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = "http://" + urlEntry.Text };
            // или так
            // webView.Source = urlEntry.Text;
        }
    }
}
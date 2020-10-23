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
    public partial class listview : ContentPage
    {
        Label header, header2;
        ListView listView;
        public listview()
        {
            header = new Label
            {
                Text = "Список моделей телефонов",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            string[] phones = new string[] { "iPhone 7", "iphone 11", "Samsung Galaxy S8", "Huawei P10", "LG G6" };

            listView = new ListView();
            listView.ItemsSource = phones;
            listView.ItemSelected += ListView_ItemSelected;

            header2 = new Label
            {
                Text = "Список фруктов",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            string[] fruits = new string[] { "Банан", "Гранат", "Апельсин", "Груша", "Персик" };

            ListView listView2 = new ListView();
            listView2.ItemsSource = fruits;
            this.Content = new StackLayout { Children = { header, listView, header2, listView2 } };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            header.Text = (string)e.SelectedItem;
        }
    }
}
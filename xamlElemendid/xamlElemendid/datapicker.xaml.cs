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
    public partial class datapicker : ContentPage
    {
        Label label;
        DatePicker datePicker;
        public datapicker()
        {
            label = new Label { Text = "Выберите дату" };
            datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now.AddDays(5),
                MinimumDate = DateTime.Now.AddDays(-5)
            };
            datePicker.DateSelected += DatePicker_DateSelected; ;
            StackLayout stack = new StackLayout { Children = { label, datePicker } };
            this.Content = stack;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            label.Text = "Вы выбрали " + e.NewDate.ToString("dd/MM/yyyy");
        }
    }
}
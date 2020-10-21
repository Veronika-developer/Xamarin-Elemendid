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
    public partial class picker : ContentPage
    {
        Label header;
        Picker pick;
        public picker()
        {
            header = new Label
            {
                Text = "Выберите язык",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            pick = new Picker
            {
                Title = "Язык"
            };
            pick.Items.Add("C#");
            pick.Items.Add("JavaScript");
            pick.Items.Add("Java");
            pick.Items.Add("PHP");

            pick.SelectedIndexChanged += Picker_SelectedIndexChanged;

            this.Content = new StackLayout { Children = { header, pick } };
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Вы выбрали: " + pick.Items[pick.SelectedIndex];
        }
    }
}
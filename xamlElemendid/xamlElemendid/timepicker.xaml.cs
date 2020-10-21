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
    public partial class timepicker : ContentPage
    {
        public timepicker()
        {
            TimePicker timePicker = new TimePicker() { Time = new TimeSpan(17, 0, 0) };
            this.Content = timePicker;
        }
    }
}
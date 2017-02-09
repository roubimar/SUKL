using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SUKL.Pages.ContentPages
{
    public partial class SearchPerscriptionPage : ContentPage
    {
        public SearchPerscriptionPage()
        {
            InitializeComponent();

            var converter = new WidthConverter();

            SearchButton.SetBinding(Button.WidthRequestProperty, new Binding("Width", converter: converter, source: this));                        
            QrButton.SetBinding(Button.WidthRequestProperty, new Binding("Width", converter: converter, source: this));
            EanButton.SetBinding(Button.WidthRequestProperty, new Binding("Width", converter: converter, source: this));
            IdEntry.SetBinding(Button.WidthRequestProperty, new Binding("Width", converter: converter, source: this));
        }
    }

    public class WidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value * 0.7;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

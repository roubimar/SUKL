using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace SUKL.Pages.ContentPages
{
    public partial class PrescriptionsPage : ContentPage
    {
        

        public PrescriptionsPage()
        {
            BindingContext = new ViewModel();
            InitializeComponent();
            Focusa();
        }    

        private void Focusa()
        {
            Device.StartTimer(new TimeSpan(0, 0, 5), callback);
            DisplayAlert("Upozornění", "Za pár vteřin vyskočí timer", "OK");     
        }

        private bool callback()
        {
            time.Focus();
            return false;
        }
    }
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<MenuItem> prescriptions;
        public ObservableCollection<MenuItem> Prescriptions
        {
            get { return prescriptions; }
            set
            {
                if (prescriptions != value)
                {
                    prescriptions = value;
                    OnPropertyChanged(nameof(this.Prescriptions));
                }
            }
        }

        // ICommand implementations
        public ICommand AddItemCommand { protected set; get; }

        public ViewModel()
        {
            Prescriptions = new ObservableCollection<MenuItem>(
                 new List<MenuItem>()
                 {
                    new MenuItem() { Text = "Ahoj"},
                    new MenuItem() { Text = "Item1"},
                    new MenuItem() { Text = "Item2"},
                    new MenuItem() { Text = "Item3"},
                    new MenuItem() { Text = "Item4"},
                 }
            );

            AddItemCommand = new Command<string>((key) =>
            {
                // Add the key to the input string.
                AddItem();
            });
        }

        public void AddItem()
        {
            Prescriptions.Add(new MenuItem() { Text = "Ahoj" });
        }        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }

    public class CustomTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public DataTemplate ValidTemplate { get; set; }
        public DataTemplate InvalidTemplate { get; set; }
        

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var text = ((MenuItem)item).Text;

            return text.Contains("Item") ? ValidTemplate : InvalidTemplate;

            return new DataTemplate(() =>
            {
                View view = new Label
                {
                    Text = text,
                    FontSize = Device.GetNamedSize(NamedSize.Default, typeof(Label)),
                    HorizontalTextAlignment = text.Contains("Item") ? TextAlignment.End : TextAlignment.Start,
                    BackgroundColor = Color.Gray
                };

                ViewCell vc = new ViewCell
                {
                    View = view
                };
                
                return vc;
            });
        }
    }
}

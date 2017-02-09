using SUKL.Pages.ContentPages;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace SUKL.Pages.MenuPages
{
    public partial class MainMenuPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MainMenuPage()
        {
            InitializeComponent();           
            //Opacity = 0.95;

            var masterPageItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Text = "Pacienti",
                    Icon = "patient.png",
                    CommandParameter = typeof(PatientsPage)
                },
                new MenuItem
                {
                    Text = "Léky",
                    Icon = "pill.png",
                    CommandParameter = typeof(CuresPage)
                },
                new MenuItem
                {
                    Text = "Recepty",
                    Icon = "prescription.png",
                    CommandParameter = typeof(PrescriptionsPage)

                },
                new MenuItem
                {
                    Text = "Signature",
                    Icon = "icon.png",
                    CommandParameter = typeof(SignaturePage)

                }
            };
            listView.ItemsSource = masterPageItems;

        }
    }
}

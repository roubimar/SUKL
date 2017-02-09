using SUKL.Pages.ContentPages;
using SUKL.Pages.MenuPages;
using System;
using Xamarin.Forms;

namespace SUKL.Pages
{
    public partial class RootPage : MasterDetailPage
    {
        private MainPage mainPage;
        private MainMenuPage masterPage;

        public RootPage()
        {
            InitializeComponent();

            masterPage = new MainMenuPage();
            masterPage.ListView.ItemSelected += OnItemSelected;

            mainPage = new MainPage(new SummaryPage());

            Master = masterPage;
            Detail = mainPage;
        }

        public async void PopToRootAsync()
        {
            await mainPage.PopToRootAsync(true);
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MenuItem item)
            {
                mainPage.PopToRootAsync();
                mainPage.PushAsync((ContentPage)Activator.CreateInstance((Type)item.CommandParameter));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}

using Xamarin.Forms;

namespace SUKL.Pages.ContentPages
{
    public partial class MainPage : NavigationPage
    {
        public MainPage(Page root = null)
        {
            InitializeComponent();
            if(root != null)
            {
                PushAsync(root);
            }
        }

        private async void Search_Clicked(object sender, System.EventArgs e)
        {
            if(!(CurrentPage is SearchPerscriptionPage))
            {
                await PushAsync(new SearchPerscriptionPage());
            }
        }
    }
}

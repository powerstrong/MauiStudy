using MauiStudy.Pages;

namespace MauiStudy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Calculator(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Calculator());
        }

        private async void Button_Clicked_GoogleMap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GoogleMapPage());
        }

        private async void Button_Clicked_mauitutorial(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NetmauiforbeginnersPage());
        }
    }
}
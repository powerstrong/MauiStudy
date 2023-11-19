using MauiStudy.Pages;
using MauiStudy.ViewModel;

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
            await Navigation.PushAsync(new NetmauiforbeginnersPage(new NetmauiforbeginnersViewModel(Connectivity.Current)));
        }

        private async void Button_Clicked_ModbusTCPTest(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModbusTcpTestPage());
        }

        private async void Button_Clicked_Stopwatch(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StopwatchPage());
        }

		private async void Button_Clicked_gRPCTest(object sender, EventArgs e)
		{
			//await Navigation.PushAsync(new Pages.TabbedPage());
		}
	}
}
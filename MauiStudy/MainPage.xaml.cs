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
    }
}
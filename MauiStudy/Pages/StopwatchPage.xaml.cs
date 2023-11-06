using MauiStudy.ViewModel;

namespace MauiStudy.Pages;

public partial class StopwatchPage : ContentPage
{
	public StopwatchPage()
	{
		InitializeComponent();
		BindingContext = new StopwatchViewModel();
	}
}
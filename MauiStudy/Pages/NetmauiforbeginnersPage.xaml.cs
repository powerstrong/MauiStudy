using MauiStudy.ViewModel;

namespace MauiStudy.Pages;

public partial class NetmauiforbeginnersPage : ContentPage
{
	public NetmauiforbeginnersPage(NetmauiforbeginnersViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
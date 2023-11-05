using MauiStudy.ViewModel;

namespace MauiStudy.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
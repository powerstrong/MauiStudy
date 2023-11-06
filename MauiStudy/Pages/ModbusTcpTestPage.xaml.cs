using MauiStudy.ViewModel;

namespace MauiStudy.Pages;

public partial class ModbusTcpTestPage : ContentPage
{
	public ModbusTcpTestPage()
	{
		InitializeComponent();
		BindingContext = new ModbusTcpTestViewModel();
	}
}
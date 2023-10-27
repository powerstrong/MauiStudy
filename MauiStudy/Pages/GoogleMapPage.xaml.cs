using System.Runtime.CompilerServices;

namespace MauiStudy.Pages;

public partial class GoogleMapPage : ContentPage
{
	public GoogleMapPage()
	{
		InitializeComponent();

		AddWebView();
	}

	private void AddWebView()
	{
		//WebView webView = new()
		//{
		//	Source = "https://google.com/maps";
		//}
	}
}
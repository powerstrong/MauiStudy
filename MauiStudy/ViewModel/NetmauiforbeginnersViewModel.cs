using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiStudy.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStudy.ViewModel
{
    public partial class NetmauiforbeginnersViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> _items;

        [ObservableProperty]
        string _text;

        IConnectivity _connectivity;
        public NetmauiforbeginnersViewModel(IConnectivity connectivity)
        {
            Items = new();
            _connectivity = connectivity;
        }

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }

            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Uh oh!", "No Internet!", "OK");
                return;
            }

            Items.Add(Text);

            // add our item
            Text = String.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        { 
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{"DetailPage"}?Text={s}");
        }
    }
}

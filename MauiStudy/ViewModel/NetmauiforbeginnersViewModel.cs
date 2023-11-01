using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

        public NetmauiforbeginnersViewModel()
        {
            Items = new();
        }

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
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
    }
}

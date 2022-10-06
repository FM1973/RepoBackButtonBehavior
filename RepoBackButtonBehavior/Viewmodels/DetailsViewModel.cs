using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace RepoBackButtonBehavior.Viewmodels
{
    public partial class DetailsViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task Back()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

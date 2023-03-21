using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUISampleDemo.ViewModels
{
    [QueryProperty(nameof(Count), nameof(Count))]
    public partial class NavPage1ViewModel : ObservableObject
    {
        [ObservableProperty]
        int count = 0;

        [RelayCommand]
        async Task Back()
        {
            await Shell.Current.GoToAsync("..");
        }
        //=> Shell.Current.GoToAsync("..");
    }
}

using CommunityToolkit.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MAUISampleDemo.ViewModels
{
    public partial class MVVMSourceGeneratorViewModel : ObservableObject
    {
        int count = 0;
        public MVVMSourceGeneratorViewModel()
        {
        }

        [ObservableProperty]
        public int countValue;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        //[property: JsonRequired]
        //[property: JsonPropertyName("fn")]
        private string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        //[property: JsonPropertyName("ln")]
        private string lastName;

        public string FullName =>
            $"{FirstName} {LastName}";


        [RelayCommand]
        async Task Submit()
        {
            Debug.WriteLine("DEBUG INFO: Submitted");
            await Task.Delay(3000);
            try
            {
                count++;
                CountValue = count;
                if (count == 1)
                    SubmitInfo(null, 5, null);
                else if (count == 2)
                    SubmitInfo(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 5, null);
                else if (count == 3)
                    SubmitInfo(new[] { 1, 2, 3 }, 5, null);
                else if (count == 4)
                    SubmitInfo(new[] { 1, 2, 3 }, 1, null);
                else if (count == 5)
                    SubmitInfo(new[] { 1, 2, 3 }, 1, "  ");
                else if (count == 6)
                    SubmitInfo(new[] { 1, 2, 3 }, 1, "Hello World");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }

        public void SubmitInfo(int[] array, int index, string text)
        {
            Guard.IsNotNull(array);
            Guard.HasSizeLessThan(array, 10);
            Guard.IsInRangeFor(index, array);
            Guard.IsNotNullOrEmpty(text);
            Guard.IsNotNullOrWhiteSpace(text);
        }
    }
}
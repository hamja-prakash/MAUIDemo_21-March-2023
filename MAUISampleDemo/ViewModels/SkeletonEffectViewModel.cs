using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.Input;
using Sentry;
using System.Windows.Input;

namespace MAUISampleDemo.ViewModels
{
    public partial class SkeletonEffectViewModel : BindableObject
    {

        private LayoutState _currentState = LayoutState.None;

        public LayoutState CurrentState
        {
            get => _currentState;
            set
            {
                if (_currentState != value)
                {
                    _currentState = value;
                    OnPropertyChanged(nameof(CurrentState));
                }
            }
        }

        public SkeletonEffectViewModel()
        {
            //CreateShimmerOperation = new Command(ShimmerOperation);
            //GetApiCall();
        }

        private async void GetApiCall()
        {
            try
            {
                await Task.Delay(4000);
                CurrentState = LayoutState.Success;
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
        }

        [RelayCommand]
        private async void ShimmerOperation(object obj)
        {
            try
            {
                CurrentState = LayoutState.Loading;
                await Task.Delay(2000);
                CurrentState = LayoutState.Success;
                SentrySdk.CaptureMessage("Hello Sentry");
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
        }
    }
}

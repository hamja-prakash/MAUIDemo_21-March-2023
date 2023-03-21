using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUISampleDemo.ViewModels
{
    public partial class AnimationViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        public bool isBusy;

        public bool IsNotBusy
        {
            get
            {
                return !IsBusy;
            }
        }

        [RelayCommand]
        public async void AnimationAction()
        {
            IsBusy = true;
            await Task.Delay(5000);
            IsBusy = false;

            //Label animatelabel = (Label)o;
            //var animation1 =  animatelabel.FadeTo(0, 250, Easing.Linear);
            //var animation2 = animatelabel.ScaleTo(1.4, 250, Easing.BounceIn);
            //await Task.WhenAll(animation1, animation2);

            //var animation3 = animatelabel.FadeTo(1, 250, Easing.Linear);
            //var animation4 = animatelabel.ScaleTo(1, 250, Easing.BounceOut);
            //var animation5 = animatelabel.RotateTo(360, 1000, Easing.Linear);
            //animatelabel.Rotation = 0;
            //await Task.WhenAll(animation3, animation4, animation5);

            //await animatelabel.FadeTo(0, 250, Easing.Linear);
            //await animatelabel.ScaleTo(1.4, 250, Easing.BounceIn);
            //await animatelabel.FadeTo(1, 250, Easing.Linear);
            //await animatelabel.ScaleTo(1, 250, Easing.BounceOut);
        }

        record struct person
        {

        }
    }
}

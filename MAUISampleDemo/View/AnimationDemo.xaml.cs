using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class AnimationDemo : ContentPage
{
    readonly Animation rotation;
    AnimationViewModel anvm;

    public AnimationDemo()
	{
		InitializeComponent();
        rotation = new Animation(v => LabelLoad.Rotation = v,
               0, 360, Easing.Linear);
        anvm = (AnimationViewModel)BindingContext;

        anvm.PropertyChanged += Animationvm_PropertyChanged;
	}

    private void Animationvm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(anvm.IsBusy))
        {
            if (anvm.IsBusy)
            {
                //animate
                rotation.Commit(this, "rotate", 16, 1000, Easing.Linear,
                    (v, c) => LabelLoad.Rotation = 0,
                    () => true);
            }
            else
            {
                //stop
                this.AbortAnimation("rotate");
            }
        }
    }
}
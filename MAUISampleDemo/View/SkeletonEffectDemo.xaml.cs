using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class SkeletonEffectDemo : ContentPage
{
	public SkeletonEffectDemo()
	{
		InitializeComponent();
		this.BindingContext = new SkeletonEffectViewModel();
	}
}
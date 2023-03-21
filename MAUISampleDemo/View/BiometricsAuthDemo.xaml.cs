using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class BiometricsAuthDemo : ContentPage
{
	public BiometricsAuthDemo(BiometricsAuthViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}
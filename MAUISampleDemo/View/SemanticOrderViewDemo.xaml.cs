namespace MAUISampleDemo.View;

public partial class SemanticOrderViewDemo : ContentPage
{
	public SemanticOrderViewDemo()
	{
		InitializeComponent();
        this.SemanticOrderView.ViewOrder = new List<Microsoft.Maui.Controls.View> { TitleLabel, DescriptionLabel };
    }
}
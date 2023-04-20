using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ExpandandCollapseClvGroupDemo : ContentPage
{
	public ExpandandCollapseClvGroupDemo()
	{
		InitializeComponent();
		this.BindingContext = new TeacherViewModel();
	}
}
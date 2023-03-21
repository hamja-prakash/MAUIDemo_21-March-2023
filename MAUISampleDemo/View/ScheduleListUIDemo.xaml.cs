using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class ScheduleListUIDemo : ContentPage
{
    private bool _isPanelTranslated;
    public ScheduleListUIDemo()
	{
		InitializeComponent();
        this.BindingContext = new ScheduleListViewModel();
        panelLeft.TranslateTo(-80, 0, 150);
    }

    private void ImgDashboard_Tapped(object sender, EventArgs e)
    {
        if (_isPanelTranslated)
        {
            panelLeft.TranslateTo(-80, 0, 150);
        }
        else
        {
            panelLeft.TranslateTo(0, 0, 150);
        }

        _isPanelTranslated = !_isPanelTranslated;
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var viewModel = (ScheduleListViewModel)BindingContext;
        viewModel.BindDataToScheduleList();
    }
}
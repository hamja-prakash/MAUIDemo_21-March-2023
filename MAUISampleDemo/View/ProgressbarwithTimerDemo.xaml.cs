namespace MAUISampleDemo.View;

public partial class ProgressbarwithTimerDemo : ContentPage
{
    private double _ProgressValue;
    public double ProgressValue
    {
        get
        {
            return _ProgressValue;
        }
        set
        {
            _ProgressValue = value;
            OnPropertyChanged();
        }
    }
    private double _Minimum;
    public double Minimum
    {
        get
        {
            return _Minimum;
        }
        set
        {
            _Minimum = value;
            OnPropertyChanged();
        }
    }
    private double _Maximum;
    public double Maximum
    {
        get
        {
            return _Maximum;
        }
        set
        {
            _Maximum = value;
            OnPropertyChanged();
        }
    }
    private System.Timers.Timer time = new System.Timers.Timer();

    public ProgressbarwithTimerDemo()
    {
        InitializeComponent();
        BindingContext = this;
        Minimum = 0;
        Maximum = 60; //60 Sec
        ProgressValue = 0;

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            lblProgressbar.Text = ProgressValue.ToString();
            if (ProgressValue < Maximum)
            {
                //You can increase Progress Value as per you requirement ProgressValue = ProgressValue + 2;
                ProgressValue++;
                return true;
            }
            else if (ProgressValue == Maximum)
            {
                time.Stop();
                return false;
            }
            else
            {
                return true;
            }
        });
    }
}

using MAUISampleDemo.Helpers;

namespace MAUISampleDemo.View;

public partial class MultiLanguageLocalizationDemo : ContentPage
{
	public MultiLanguageLocalizationDemo()
	{
		InitializeComponent();
	}

    private void rbIndia_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        try
        {
            Translator.Instance.CultureInfo = new System.Globalization.CultureInfo("hi-IN");
            Translator.Instance.OnPropertyChanged();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void rbUS_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        try
        {
            Translator.Instance.CultureInfo = new System.Globalization.CultureInfo("en-US");
            Translator.Instance.OnPropertyChanged();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void rbNetherland_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        try
        {
            Translator.Instance.CultureInfo = new System.Globalization.CultureInfo("nl-NL");
            Translator.Instance.OnPropertyChanged();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}
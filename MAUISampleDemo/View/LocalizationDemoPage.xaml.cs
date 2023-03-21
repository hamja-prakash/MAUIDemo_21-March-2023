using System.Globalization;

namespace MAUISampleDemo.View;

public partial class LocalizationDemoPage : ContentPage
{
    int count = 0;
    public LocalizationResourceManager LocalizationResourceManager
        => LocalizationResourceManager.Instance;

    public LocalizationDemoPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var switchToCulture = MAUISampleDemo.Resources.Language.AppResources.Culture.TwoLetterISOLanguageName
            .Equals("nl", StringComparison.InvariantCultureIgnoreCase) ?
            new CultureInfo("en-US") : new CultureInfo("nl-NL");

        LocalizationResourceManager.Instance.SetCulture(switchToCulture);

        count++;

        CounterBtn.Text = String.Format(LocalizationResourceManager["Counter"].ToString(), count);
    }
}
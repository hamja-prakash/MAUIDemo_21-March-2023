namespace MAUISampleDemo.Helpers;

public partial class LoaderControl : StackLayout
{
	public LoaderControl()
	{
		InitializeComponent();
	}

	#region Activity Indicator property
	public static readonly BindableProperty IndicatorColorProperty = BindableProperty.Create(
	propertyName: nameof(IndicatorColor),
	returnType: typeof(Color),
	defaultValue: Colors.LightBlue,
	declaringType: typeof(LoaderControl),
	defaultBindingMode: BindingMode.OneWay
	);

	public Color IndicatorColor
	{
		get => (Color)GetValue(IndicatorColorProperty);
		set=> SetValue(IndicatorColorProperty, value);
	}
    #endregion

    #region LoaderText
    public static readonly BindableProperty LoadingTextProperty = BindableProperty.Create(
    propertyName: nameof(LoaderText),
    returnType: typeof(string),
    defaultValue: "Please Wait..",
    declaringType: typeof(LoaderControl),
    defaultBindingMode: BindingMode.OneWay
    );

    public string LoaderText
    {
        get => (string)GetValue(LoadingTextProperty);
		set => SetValue(LoadingTextProperty, value);	
    }
    #endregion

    #region LoaderTextColor
    public static readonly BindableProperty LoadingTextColorProperty = BindableProperty.Create(
    propertyName: nameof(LoadingTextColor),
    returnType: typeof(Color),
    defaultValue: Colors.Black,
    declaringType: typeof(LoaderControl),
    defaultBindingMode: BindingMode.OneWay
    );

    public Color LoadingTextColor
    {
        get => (Color)GetValue(LoadingTextColorProperty);
        set => SetValue(LoadingTextColorProperty, value);
    }
    #endregion
}
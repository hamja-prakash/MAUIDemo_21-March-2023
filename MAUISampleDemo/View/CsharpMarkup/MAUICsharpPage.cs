using Microsoft.Maui.Controls;

namespace MAUISampleDemo.View.CsharpMarkup;

public class MAUICsharpPage : ContentPage
{
	int count = 0;
	public MAUICsharpPage()
	{
		var scrollview = new ScrollView();
		var verticalstackLayout = new VerticalStackLayout
		{
			Spacing = 25,
			Padding = 30,
		};

		scrollview.Content = verticalstackLayout;

		var helloworldLabel = new Label
		{
			Text = "Hello World from C#",
			FontSize = 32,
			HorizontalOptions = LayoutOptions.Center,
		};
        SemanticProperties.SetHeadingLevel(helloworldLabel, SemanticHeadingLevel.Level1);
		verticalstackLayout.Children.Add(helloworldLabel);

        var countLabel = new Label
        {
            Text = "Current count: 0",
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
		};

        verticalstackLayout.Children.Add(countLabel);

        var button = new Button
        {
            Text = "Click me",
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
        };

        SemanticProperties.SetHint(button, "Counts the number of times you click");
        button.Clicked += (sender, args) =>
        {
            count++;
            countLabel.Text = $"Current count: {count}";
            SemanticScreenReader.Announce(countLabel.Text);
        };
        verticalstackLayout.Children.Add(button);

        var image = new Image
        {
            Source = new FileImageSource
            {
                File = "dotnet_bot.png",
            },
            WidthRequest = 250,
            HeightRequest = 310,
            HorizontalOptions = LayoutOptions.Center
        };
        verticalstackLayout.Children.Add(image);

        Content = scrollview;
    }
}
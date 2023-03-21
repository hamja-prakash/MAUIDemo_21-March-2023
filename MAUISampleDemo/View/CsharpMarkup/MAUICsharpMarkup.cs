using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.View.CsharpMarkup
{
    public class MAUICsharpMarkup : ContentPage
    {
        int count = 0;

        public MAUICsharpMarkup()
        {
            var scrollView = new ScrollView();
            var verticalStackLayout = new VerticalStackLayout
            {
                Spacing = 25,
                Padding = 30,
                Children =
            {
                new Label
                {
                    Text = "Hello, World from C# Markup!",
                    FontSize = 32,
                    HorizontalOptions= LayoutOptions.Center,
                },
                //new Label
                //{
                //    Text = "Current count: 0",
                //    FontSize = 20,
                //    FontAttributes = FontAttributes.Bold,
                //},
                //new Button
                //{
                //    Text = "Click me",
                //    FontSize = 32,
                //}
                //.Invoke(b => b.Clicked += (sender, e) =>
                //{
                //    count++;
                //    countLabel.Text = $"Current count: {count}";

                //    SemanticScreenReader.Announce(countLabel.Text);
                //}),

                new Image
                {
                    Source = new FileImageSource
                    {
                        File = "dotnet_bot.png",
                    },
                    WidthRequest = 250,
                    HeightRequest = 310,
                    HorizontalOptions = LayoutOptions.Center,
                }
            }
            };
            scrollView.Content = verticalStackLayout;

            Content = scrollView;
        }
    }
}

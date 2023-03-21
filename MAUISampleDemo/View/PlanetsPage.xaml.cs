using MAUISampleDemo.Helpers;
using System.Numerics;

namespace MAUISampleDemo.View;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 200u;

    public PlanetsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        // Reveal our menu and move the main content out of the view
        await MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        await MainContentGrid.FadeTo(0.8, AnimationDuration);
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
       // await CloseMenu();
    }

    private async Task CloseMenu()
    {
        //Close the menu and bring back back the main content
        await MainContentGrid.FadeTo(1, AnimationDuration);
        await MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }

    private async void ImgClose_Clicked(object sender, EventArgs e)
    {
        try
        {
            await CloseMenu();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
namespace MAUISampleDemo.View;

public partial class BMICalculationDemo : ContentPage
{
    public string Selectedradiobtn = "radiobtncheck.png";
    public string Unselectedradiobtn = "radiobtnuncheck.png";

    public BMICalculationDemo()
    {
        InitializeComponent();
    }

    private void btnMale_Tapped(object sender, EventArgs e)
    {
        try
        {
            GenderSelection();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void btnFemale_Tapped(object sender, EventArgs e)
    {
        try
        {
            GenderSelection();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    public void GenderSelection()
    {
        try
        {
            if (imgMale.Source.ToString().Replace("File: ", "") == Selectedradiobtn)
            {
                imgMale.Source = Unselectedradiobtn;
                imgFemale.Source = Selectedradiobtn;
            }
            else if (imgFemale.Source.ToString().Replace("File: ", "") == Selectedradiobtn)
            {
                imgFemale.Source = Unselectedradiobtn;
                imgMale.Source = Selectedradiobtn;
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    public void BMICalculation()
    {
        try
        {
            double Height = 0.0;
            double Weight = 0.0;

            var weightvalue = new string(lblWeight.Text.Where(char.IsDigit).ToArray());
            var heightvalue = new string(lblHeight.Text.Where(char.IsDigit).ToArray());
            double.TryParse(weightvalue, out Weight);
            double.TryParse(heightvalue, out Height);

            var heightmm = (Height * 0.01);
            var BMI = Weight / (heightmm * heightmm);
            lblResult.Text = BMI.ToString("F2");
            lblSepration.IsVisible = true;
            if (BMI < 18.5)
            {
                lblInterpretBMI.Text = "Underweight";
                lblInterpretBMI.TextColor = Colors.Orange;
            }
            else if (BMI < 25)
            {
                lblInterpretBMI.Text = "Normal";
                lblInterpretBMI.TextColor = Colors.Green;
            }
            else if (BMI < 30)
            {
                lblInterpretBMI.Text = "Overweight";
                lblInterpretBMI.TextColor = Colors.Blue;
            }
            else
            {
                lblInterpretBMI.Text = "Obese";
                lblInterpretBMI.TextColor = Colors.Red;
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void btnBMI_Clicked(object sender, EventArgs e)
    {
        try
        {
            BMICalculation();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBackBtn_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}
using MAUISampleDemo.Model;

namespace MAUISampleDemo.View.Database;

public partial class CRUDoperationDemo : ContentPage
{
	public CRUDoperationDemo()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        collectionView.ItemsSource = await App.Database.GetPeopleAsync();
    }

    // Save
    async void BtnSave_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(nameEntry.Text))
        {
            await App.Database.SavePersonAsync(new Person
            {
                Name = nameEntry.Text,
                IsPSSPLEmployee = PSSPLEmployee.IsChecked
            });

            nameEntry.Text = string.Empty;
            PSSPLEmployee.IsChecked = false;

            collectionView.ItemsSource = await App.Database.GetPeopleAsync();
        }
    }

    Person lastSelection;
    void collectionView_SelectionChanged(System.Object sender, SelectionChangedEventArgs e)
    {
        lastSelection = e.CurrentSelection[0] as Person;
        nameEntry.Text = lastSelection.Name;
        PSSPLEmployee.IsChecked = lastSelection.IsPSSPLEmployee;
    }

    // Update
    async void BtnUpdate_Clicked(System.Object sender, System.EventArgs e)
    {
        if (lastSelection != null)
        {
            lastSelection.Name = nameEntry.Text;
            lastSelection.IsPSSPLEmployee = PSSPLEmployee.IsChecked;

            await App.Database.UpdatePersonAsync(lastSelection);

            collectionView.ItemsSource = await App.Database.GetPeopleAsync();

            nameEntry.Text = "";
            PSSPLEmployee.IsChecked = false;
        }
    }

    // Delete
    async void BtnDelete_Clicked(System.Object sender, System.EventArgs e)
    {
        if (lastSelection != null)
        {
            await App.Database.DeletePersonAsync(lastSelection);

            collectionView.ItemsSource = await App.Database.GetPeopleAsync();

            nameEntry.Text = "";
            PSSPLEmployee.IsChecked = false;
        }
    }

    // Is PSSPL Employee
    async void BtnEmployee_Clicked(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = await App.Database.QueryEmployeeAsync();
    }

    // Is not PSSPL Employee
    async void BtnNotEmployee_Clicked(System.Object sender, System.EventArgs e)
    {
        collectionView.ItemsSource = await App.Database.LinqNotEmployeeAsync();
    }
}
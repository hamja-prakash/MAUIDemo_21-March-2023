using MAUISampleDemo.Helpers;
using System;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.View;

public partial class ContextandMenuActioninListView : ContentPage
{
    ObservableCollection<Faculty> mFaculties;
    public ContextandMenuActioninListView()
	{
		InitializeComponent();
        mFaculties =new ObservableCollection<Faculty>();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        BindFacultyData();
    }

    public void BindFacultyData()
	{
		try
		{
			
			mFaculties.Add(new Faculty
			{
				Name = "Test 1",
				Email = "test123@gmail.com",
            });

            mFaculties.Add(new Faculty
            {
                Name = "Test 2",
                Email = "test12@gmail.com"
            });

            mFaculties.Add(new Faculty
            {
                Name = "Test 3",
                Email = "test13@gmail.com"
            });

            mFaculties.Add(new Faculty
            {
                Name = "Data 4",
                Email = "test14@gmail.com"
            });

            mFaculties.Add(new Faculty
            {
                Name = "Test 5",
                Email = "test5@gmail.com"
            });

            lstFaculty.ItemsSource = mFaculties.ToList();
        }
		catch (Exception ex)
		{
            var err = ex.Message;
		}
	}

    private void BtnDelete_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (sender is MenuItem menuItem && menuItem.BindingContext is Faculty mFaculty)
            {
                lstFaculty.ItemsSource = null;
                if (mFaculty != null)
                    mFaculties.Remove(mFaculty);
                lstFaculty.ItemsSource = mFaculties.ToList();
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}

public class Faculty
{
	public string Name { get; set; }
	public string Email { get; set; }
    public Color BackgroundColor
    {
        get => Common.GetRandomColor();

    }
    public char FirstCharOfName
    {
        get => !string.IsNullOrWhiteSpace(Name) ? Name.ToCharArray()[0] : ' ';
    }

    public char test()
    {
        return Name.ToCharArray()[0];
    }
}
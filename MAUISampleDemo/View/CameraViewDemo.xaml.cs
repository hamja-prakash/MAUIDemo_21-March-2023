using MAUISampleDemo.Model;

namespace MAUISampleDemo.View;

public partial class CameraViewDemo : ContentPage
{
    public string FrontCamera = "Front Camera";
    public string BackCamera = "Back Camera";
    public string CheckIcon = "iconsquarecheck.png";
    public string UnCheckIcon = "iconsquareuncheck.png";
    public List<WeekDays> mWeekdays;

    public CameraViewDemo()
    {
        InitializeComponent();
        mWeekdays = new List<WeekDays>();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //BindWeekDayData();
    }


    private void CameraView_CamerasLoaded(object sender, EventArgs e)
    {
        try
        {
            //CameraView.Camera = CameraView.Cameras.Where(x => x.Name.ToLower().Equals(FrontCamera.ToLower())).FirstOrDefault();
            CameraView.Camera = CameraView.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await CameraView.StopCameraAsync();
                await CameraView.StartCameraAsync();
            });
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        try
        {
            imgCamera.Source = CameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
            imgDelete.IsVisible = true;
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void BtnDelete_Clicked(object sender, EventArgs e)
    {
        try
        {
            var result = await App.Current.MainPage.DisplayAlert("Alert", "are you sure you want to delete this image", "Ok", "Cancel");
            if (result)
            {
                imgCamera.Source = "noimage.png";
                imgDelete.IsVisible = false;
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //public void BindWeekDayData()
    //{
    //    try
    //    {
    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Monday",
    //            CheckImg = UnCheckIcon
    //        });

    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Tuesday",
    //            CheckImg = UnCheckIcon
    //        });

    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Wednesday",
    //            CheckImg = UnCheckIcon
    //        });

    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Thursday",
    //            CheckImg = UnCheckIcon
    //        });

    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Friday",
    //            CheckImg = UnCheckIcon
    //        });

    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Saturday",
    //            CheckImg = UnCheckIcon
    //        });

    //        mWeekdays.Add(new WeekDays
    //        {
    //            Name = "Sunday",
    //            CheckImg = UnCheckIcon
    //        });

    //        clvWeekDays.ItemsSource = mWeekdays.ToList();
    //    }
    //    catch (Exception ex)
    //    {
    //        var er = ex.Message;
    //    }
    //}

    //private void btnSubmit_Clicked(object sender, EventArgs e)
    //{
    //    var checkdayslist = mWeekdays.Where(x => x.CheckImg == CheckIcon).ToList();
    //    if (checkdayslist != null && checkdayslist.Count > 0)
    //    {

    //    }
    //}

    //private void BtnCheck_Clicked(object sender, EventArgs e)
    //{
    //    if (sender is Grid grd && grd.BindingContext is Model.WeekDays mWeek)
    //    {
    //        if (mWeek != null)
    //        {
    //            if (mWeek.CheckImg.ToString().Replace(":", "") == UnCheckIcon)
    //            {
    //                mWeek.CheckImg = CheckIcon;
    //            }
    //            else
    //            {
    //                mWeek.CheckImg = UnCheckIcon;
    //            }
    //        }
    //    }
    //}

    //private void ImgCheck_Clicked(object sender, EventArgs e)
    //{
    //    if (sender is ImageButton imgbtn && imgbtn.BindingContext is Model.WeekDays mWeek)
    //    {
    //        if (mWeek != null)
    //        {
    //            if (mWeek.CheckImg.ToString().Replace(":", "") == UnCheckIcon)
    //            {
    //                mWeek.CheckImg = CheckIcon;
    //            }
    //            else
    //            {
    //                mWeek.CheckImg = UnCheckIcon;
    //            }
    //        }
    //    }

    //}
}
using MauiPopup.Views;
using MauiPopup;
using System.Collections;

namespace MAUISampleDemo.Helpers;

public partial class PickerControlView : BasePopupPage
{
    public PickerControlView(IEnumerable itemSource, DataTemplate itemTemplate, double pickerControlHeight = 200)
    {
        InitializeComponent();

        clPickerView.ItemsSource = itemSource;
        clPickerView.ItemTemplate = itemTemplate;
        grv.HeightRequest = pickerControlHeight;
    }

    private void clPickerView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var currentItem = e.CurrentSelection.FirstOrDefault();
        PopupAction.ClosePopup(currentItem);
    }
}
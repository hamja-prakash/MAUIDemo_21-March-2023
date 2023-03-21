using CommunityToolkit.Mvvm.ComponentModel;

namespace MAUISampleDemo.Model
{
    public partial class Employee : ObservableObject
    {
        [ObservableProperty]
        private string employeeName;
        [ObservableProperty]
        private bool isBeingDragged;
        [ObservableProperty]
        private bool isBeingDraggedOver;
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.ViewModels
{
    public partial class FloatingActionButtonViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public bool _rotate;

        [ObservableProperty]
        public Thickness marginValue;

        [ObservableProperty]
        public string containerName;

        public FloatingActionButtonViewModel()
        {
            MarginValue = new Thickness(0, 0, -100, 50);
            containerName = "FrmContainer";
        }

        [RelayCommand]
        private async void BtnClick(object sender)
        {
            try
            {
                var frmfltacbtn = sender as Button;
                await frmfltacbtn.RotateTo(_rotate ? 0 : -90);
                _rotate = !_rotate;
                MarginValue = new Thickness(0, 0, _rotate ? 0 : -100, 50);
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
        }
    }
}

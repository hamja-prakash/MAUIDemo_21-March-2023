using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUISampleDemo.Helpers;
using MAUISampleDemo.Model;
using System.Collections.ObjectModel;

namespace MAUISampleDemo.ViewModels
{
    public partial class MVVMDatabindingViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; set; }
        [ObservableProperty]
        private bool isRefreshing;
        public ProductAPI productAPI;

        public MVVMDatabindingViewModel()
        {
            Products = new ObservableCollection<Product>();
            productAPI = new ProductAPI();
        }

        [RelayCommand]
        private async Task BindProductData()
        {
            try
            {
                var productList = await productAPI.GetProducts();
                if (productList != null && productList.Count > 0)
                {
                    foreach (var item in productList)
                        Products.Add(item);
                }
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
            finally
            {
                IsRefreshing = false;
            }
        }
    }
}

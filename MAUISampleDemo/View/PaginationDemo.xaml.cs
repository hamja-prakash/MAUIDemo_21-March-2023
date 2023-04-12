using MAUISampleDemo.API;
using MAUISampleDemo.Model.APIModels;
using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class PaginationDemo : ContentPage
{
    public PaginationDemo()
	{
		InitializeComponent();
		this.BindingContext = new PaginationViewModel();
    }

    //private void clvEntries_ItemAppearing(object sender, ItemVisibilityEventArgs e)
    //{
    //    var item = (EntryModel)e.Item;
    //    if (paginationViewModel.EntriesList.Count >= paginationViewModel.pagesize)
    //    {
    //        if (item == paginationViewModel.EntriesList.Last())
    //        {
    //            paginationViewModel.pagesize += paginationViewModel.pagesize;
    //            paginationViewModel.LoadMoreData();
    //        }
    //    }
    //}
}
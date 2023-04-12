using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUISampleDemo.API;
using MAUISampleDemo.Model.APIModels;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MvvmHelpers;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MAUISampleDemo.ViewModels
{
    public partial class PaginationViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        public EntriesAPI entriesAPI;
        public ObservableCollection<EntryModel> EntriesList { get; set; }
        public List<EntryModel> _allEntries;
        public int pagesize = 10;

        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        public bool isLoad;

        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        public bool isLoadMoreData;

        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        public int totalRecords;

        [CommunityToolkit.Mvvm.ComponentModel.ObservableProperty]
        public int loadRecords;

        public PaginationViewModel()
        {
            entriesAPI = new EntriesAPI();
            EntriesList = new ObservableCollection<EntryModel>();
            LoadRecords = 0;
            TotalRecords = 0;
            BindAllEntries();
        }

        public void BindAllEntries()
        {
            try
            {
                EntriesList.Clear();
                Task.Run(async () =>
                {
                    ShowLoader(true);
                    var EntryResult = await entriesAPI.GetEntries();
                    if (EntryResult != null)
                    {
                        ShowLoader(false);
                        if (EntryResult.entries != null && EntryResult.entries.Count > 0)
                        {
                            _allEntries = EntryResult.entries;
                            TotalRecords = EntryResult.entries.Count;
                            App.Current.Dispatcher.Dispatch(() =>
                            {
                                var records = _allEntries.Take(pagesize).ToList();
                                foreach (var record in records)
                                    EntriesList.Add(record);
                                //EntriesList.AddRange(_allEntries.Take(pagesize).ToList());
                            });
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            finally
            {
                ShowLoader(false);
            }
        }

        [RelayCommand]
        public async void LoadMoreData()
        {
           // await Task.Delay(500);
            if (IsLoadMoreData) return;
            if (_allEntries?.Count > 0)
            {
                ShowLoaderForMoreData(true);
                await Task.Delay(1 * 1000);
                var loadMoreDatas = _allEntries.Take(pagesize).ToList();
                foreach (var record in loadMoreDatas)
                    EntriesList.Add(record);
                LoadRecords = EntriesList.Count;
                //EntriesList.ReplaceRange(_allEntries.Skip(EntriesList.Count).Take(pagesize).ToList());
                ShowLoaderForMoreData(false);
            }
        }

        public void ShowLoader(bool isLoad)
        {
            try
            {
                IsLoad = isLoad;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        public void ShowLoaderForMoreData(bool isLoad)
        {
            try
            {
                IsLoadMoreData = isLoad;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;
    }
}

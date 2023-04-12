using MAUISampleDemo.Model.APIModels;

namespace MAUISampleDemo.API
{
    public class EntriesAPI
    {
        public APIService aPIService = new APIService();
        public async Task<EntryListner> GetEntries()
        {
            return await aPIService.GetAsync<EntryListner>(string.Format(ApiConstant.GetEntries));
        }
    }
}

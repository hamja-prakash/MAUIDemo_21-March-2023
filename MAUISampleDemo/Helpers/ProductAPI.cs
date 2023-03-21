using MAUISampleDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Helpers
{
    public class ProductAPI
    {
        public APIService aPIService = new APIService();

        public async Task<List<Product>> GetProducts()
        {
            return await aPIService.GetAsync<List<Product>>(string.Format(ApiConstant.GetProducts));
        }
    }
}

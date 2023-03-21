using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Helpers
{
    public class ApiConstant
    {
        public static string BaseApiUrl = "https://fakestoreapi.com/";
        public static string GetProducts = "products";
        public static string DeleteProductById = "products/{0}"; // 0 = id
        public static string ProductDetailsById = "products/{0}"; // 0 = id
        public static string InsertProduct = "products";
    }
}

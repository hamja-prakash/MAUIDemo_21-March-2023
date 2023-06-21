using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Platforms
{
    public static class Messages
    {
        public static async Task SayHello(this Page page)
        {
            await page.DisplayAlert("Hello", "Hello from Windows!", "OK");
        }
    }
}

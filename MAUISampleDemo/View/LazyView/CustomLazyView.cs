using CommunityToolkit.Maui.Markup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.View.LazyView
{
    public class CustomLazyView<TView> : MAUISampleDemo.Shared.LazyView where TView : Microsoft.Maui.Controls.View, new()
    {
        public override async ValueTask LoadViewAsync()
        {
            // display a loading indicator
            Content = new ActivityIndicator { IsRunning = true }.Center();

            // simulate a long running task
            await Task.Delay(3000);

            // load the view
            Content = new TView { BindingContext = BindingContext };

            SetHasLazyViewLoaded(true);
        }
    }
}

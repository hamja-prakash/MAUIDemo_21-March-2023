using MAUISampleDemo.Shared;

namespace MAUISampleDemo.View.LazyView
{
    public class MyLazyView : LazyView<MyView>
    {
        public override async ValueTask LoadViewAsync()
        {
            await base.LoadViewAsync();
        }
    }
}

namespace MAUISampleDemo.Helpers
{
    public class TranslateExtension : IMarkupExtension
    {
        public string Key { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var binding = new Binding
            {
                Path = $"[{Key}]",
                Mode = BindingMode.OneWay,
                Source = Translator.Instance,
            };
            return binding;
        }
    }
}

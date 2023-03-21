using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISampleDemo.Shared
{
    public class SemanticOrderView : ContentView, ISemanticOrderView
    {
        /// <summary>
        /// Backing BindableProperty for the <see cref="ViewOrder"/> property.
        /// </summary>
        public static readonly BindableProperty ViewOrderProperty =
            BindableProperty.Create(nameof(ViewOrder), typeof(IEnumerable), typeof(SemanticOrderView), Enumerable.Empty<View>());

        /// <inheritdoc />
        public IEnumerable<IView> ViewOrder
        {
            get => (IEnumerable<IView>)GetValue(ViewOrderProperty);
            set => SetValue(ViewOrderProperty, value);
        }
    }

    public interface ISemanticOrderView : IContentView
    {
        /// <summary>
        /// The semantic order to traverse child views
        /// </summary>
        IEnumerable<IView> ViewOrder { get; }
    }
}

﻿using CommunityToolkit.Maui.Behaviors;
using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.Helpers
{
    public class TintColorBehavior : Behavior<Image>
    {
        public static readonly BindableProperty AttachBehaviorProperty =
       BindableProperty.CreateAttached("AttachBehavior", typeof(bool), typeof(TintColorBehavior), false, propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            var image = view as Image;
            if (image == null)
                return;

            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                image.Behaviors.Add(new IconTintColorBehavior() { TintColor = (image.BindingContext as ImagechangecolorViewModel).TintColor });
            }
            else
            {
                var toRemove = image.Behaviors.FirstOrDefault(b => b is IconTintColorBehavior);
                if (toRemove != null)
                {
                    image.Behaviors.Remove(toRemove);
                }
            }
        }
    }
}

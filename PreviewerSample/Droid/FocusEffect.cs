using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PreviewerSample.Droid;

[assembly: ResolutionGroupName("ytabuchi")]
[assembly: ExportEffect(typeof(FocusEffect), "FocusEffect")]

namespace PreviewerSample.Droid
{
    public class FocusEffect : PlatformEffect
    {
        Android.Graphics.Color backgroundColor;

        protected override void OnAttached()
        {
            backgroundColor = Android.Graphics.Color.Rgb(120, 182, 226);
            Control.SetBackgroundColor(backgroundColor);
        }

        protected override void OnDetached()
        {
            //throw new NotImplementedException();
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == "IsFocused")
            {
                if (((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == backgroundColor)
                    Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                else
                    Control.SetBackgroundColor(backgroundColor);
            }
        }
    }
}


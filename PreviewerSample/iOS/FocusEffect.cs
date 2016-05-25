using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using PreviewerSample.iOS;
using UIKit;

[assembly: ResolutionGroupName("ytabuchi")]
[assembly: ExportEffect(typeof(FocusEffect), "FocusEffect")]

namespace PreviewerSample.iOS
{
    public class FocusEffect : PlatformEffect
    {
        UIColor backgroundColor;

        protected override void OnAttached()
        {
            backgroundColor = UIColor.FromRGB(200, 170, 200);
            Control.BackgroundColor = backgroundColor;
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
                if (Control.BackgroundColor == backgroundColor)
                    Control.BackgroundColor = UIColor.Clear;
                else
                    Control.BackgroundColor = backgroundColor;
            }
        }
    }
}


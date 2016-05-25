using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using PreviewerSample.Helper;
using PreviewerSample.Droid;

[assembly: ExportRenderer(typeof(RoundedButton), typeof(RoundedButtonRenderer))]
namespace PreviewerSample.Droid
{
    class RoundedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.RoundedButton);
            }
        }
    }
}
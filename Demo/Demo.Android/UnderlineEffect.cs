using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Demo.Droid.Renderers;
using Demo.Infraestructure.CustomForms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName(UnderLineEffect.EffectNamespace)]
[assembly: ExportEffect(typeof(UnderLineEffect), nameof(UnderlineEffect))]

namespace Demo.Droid.Renderers
{
    //[assembly: ResolutionGroupName(UnderlineLabel.UnderlineEffect.EffectNamespace)]
    //[assembly: ExportEffect(typeof(UnderlineEffect), nameof(UnderlineEffect))]
   
    public class UnderlineEffect: PlatformEffect 
    {
        protected override void OnAttached()
        {
            SetUnderline(true);
        }

        protected override void OnDetached()
        {
            SetUnderline(false);
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == Label.TextProperty.PropertyName || args.PropertyName == Label.FormattedTextProperty.PropertyName)
            {
                SetUnderline(true);
            }
        }

        private void SetUnderline(bool underlined)
        {
            try
            {
                var textView = (TextView)Control;
                if (underlined)
                {
                    textView.PaintFlags |= PaintFlags.UnderlineText;
                }
                else
                {
                    textView.PaintFlags &= ~PaintFlags.UnderlineText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot underline Label. Error: ", ex.Message);
            }
        }

    }
}
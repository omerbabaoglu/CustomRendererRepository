using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomRendererSampleApp.CustomRenderers;
using CustomRendererSampleApp.Droid.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly : Xamarin.Forms.ExportRenderer(typeof(CustomEntry),typeof(EntryCustomRenderer))]
namespace CustomRendererSampleApp.Droid.CustomRenderers
{
    
    public class EntryCustomRenderer : EntryRenderer
    {
        public EntryCustomRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {

       
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.Hint = "Android tarafı";
                Control.SetTextColor(Android.Graphics.Color.LightSalmon);
                Control.SetBackgroundColor(Android.Graphics.Color.LightGreen);
                
                
            }
        }
    }
}
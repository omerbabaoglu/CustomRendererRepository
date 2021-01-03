using CustomRendererSampleApp.CustomRenderers;
using CustomRendererSampleApp.UWP.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Color = Xamarin.Forms.Color;
using SolidColorBrush = Xamarin.Forms.SolidColorBrush;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace CustomRendererSampleApp.UWP.CustomRenderers
{

    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.PlaceholderText = "UWP tarafı";
                
                // Text Color -> normal 
                Control.Foreground = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(126, 0, 255, 0));
                // Text Color ->  focus
               //Control.ForegroundFocusBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(200, 25, 0, 200));


                // Background Color -> normal
                Control.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 25, 0));
                // Background Color -> focus
               // Control.BackgroundFocusBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 255));

                


                //Control.BorderThickness = new Windows.UI.Xaml.Thickness();
                //Control.SelectionHighlightColor = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(126, 255, 50, 255));
                //Control.PlaceholderForegroundBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(126, 45, 45, 255));
                //Control.PlaceholderForegroundFocusBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb(126, 25, 255, 30));
                //Control.IsColorFontEnabled = true;



            }
        }

     

       
    }
    
}

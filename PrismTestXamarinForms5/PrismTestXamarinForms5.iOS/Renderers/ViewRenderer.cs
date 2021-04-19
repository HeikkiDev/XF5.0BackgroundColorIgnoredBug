using Xamarin.Forms;

// Comment below line to getting back background color on Grid, Stacklayout etc
[assembly: ExportRenderer(typeof(View), typeof(PrismTestXamarinForms5.iOS.Renderers.ViewRenderer))]
namespace PrismTestXamarinForms5.iOS.Renderers
{
    internal class ViewRenderer : Xamarin.Forms.Platform.iOS.ViewRenderer
    {
        
    }
}
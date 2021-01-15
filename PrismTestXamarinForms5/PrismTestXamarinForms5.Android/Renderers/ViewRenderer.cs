using Android.Content;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(View), typeof(PrismTestXamarinForms5.Droid.Renderers.ViewRenderer))]
namespace PrismTestXamarinForms5.Droid.Renderers
{
    internal class ViewRenderer : Xamarin.Forms.Platform.Android.ViewRenderer

    {
        public ViewRenderer(Context context) : base(context)
        {
        }
    }
}
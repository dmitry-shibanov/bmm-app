using Android.App;
using Android.Graphics;
using Android.Views;
using BMM.UI.Droid.Application.Extensions;

namespace BMM.UI.Droid.Utils
{
    public class ViewUtils
    {
        public static void SetSpecifiedNavigationBarColor(Activity activity, Color color) 
            => SetNavigationBarColor(activity, color);

        public static void SetDefaultNavigationBarColor(Activity activity) 
            => SetNavigationBarColor(activity, activity.GetColorFromResource(Resource.Color.label_primary_reverted_color));

        private static void SetNavigationBarColor(Activity activity, Color color)
        {
            activity.Window.ClearFlags(WindowManagerFlags.TranslucentNavigation);
            activity.Window.SetNavigationBarColor(color);
        }
    }
}
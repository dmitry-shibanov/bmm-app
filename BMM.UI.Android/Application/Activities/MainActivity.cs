using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using MvvmCross.ViewModels;
using MvvmCross;

namespace BMM.UI.Droid.Application.Activities
{
    [Activity(
         Label = "BMM",
         Theme = "@style/AppTheme",
         LaunchMode = LaunchMode.SingleTask,
         Name = "bmm.ui.droid.application.activities.MainActivity",
         WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.AdjustPan,
         ScreenOrientation = ScreenOrientation.Portrait,
         Exported = true
    )]
    [IntentFilter(
        new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        AutoVerify = true,
        DataSchemes = new[] { "https", "http" },
        DataPathPatterns = new[]
        {
            "/archive", "/album/.*", "/track/.*", "/playlist/curated/.*", "/playlist/private/.*", "/playlist/shared/.*", "/playlist/contributor/.*", "/playlist/podcast/.*", "/podcasts/.*", "/playlist/latest", "/copyright", "/", "/daily-fra-kaare", "/music", "/speeches", "/contributors", "/featured", "/browse/.*"
        }
    )]
    public class MainActivity : Activity
    {
        private BottomNavigationView? _bottomNavigationView;
        private FrameLayout _miniPlayerFrame;
        private string _unhandledDeepLink;
        private static int? _currentAppTheme;
        
        private FrameLayout MiniPlayerFrame
            => _miniPlayerFrame ??= FindViewById<FrameLayout>(Resource.Id.miniplayer_frame);

        protected override void OnCreate(Bundle bundle)
        {
            SetContentView(Resource.Layout.activity_main);
            base.OnCreate(bundle);

            Xamarin.Essentials.Platform.Init(this, bundle);

            // This is necessary when we open the app through a deep link. For some reason Start() is not called automatically.
            // ToDo: Due to the fact that the app doesn't start properly we also see a white screen instead of the SplashScreen
            var startup = Mvx.IoCProvider.Resolve<IMvxAppStart>();
            startup.Start();
            SetCurrentTheme();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void SetCurrentTheme()
        {
            _currentAppTheme = AppCompatDelegate.DefaultNightMode;
        }

        private bool ThemeHasChanged()
        {
            if (_currentAppTheme == null)
                return false;

            return _currentAppTheme != AppCompatDelegate.DefaultNightMode;
        }
    }
}
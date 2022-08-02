using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Runtime;
using Android.Util;
using AndroidX.AppCompat.Widget;
using AndroidX.CardView.Widget;
using AndroidX.DrawerLayout.Widget;
using AndroidX.ViewPager.Widget;
using BMM.Core;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using MvvmCross;
using MvvmCross.Base;
using MvvmCross.DroidX;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.IoC;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace BMM.UI.Droid
{
    public class AndroidSetup : MvxAndroidSetup<App>
    {
        protected override IMvxApplication CreateApp()
        {
            AndroidEnvironment.UnhandledExceptionRaiser += (sender, args) =>
            {
                LogError("AndroidEnvironment.UnhandledException", args.Exception.ToString());
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                LogError("AppDomain.CurrentDomain.UnhandledException", args.ExceptionObject.ToString());
            };

            return new App();
        }

        private void LogError(string location, string exception)
        {
#if DEBUG
            Log.Error(location, exception);
#endif
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies
        {
            get
            {
                var assemblies = new List<Assembly>(base.AndroidViewAssemblies)
                {
                    typeof(NavigationView).Assembly,
                    typeof(FloatingActionButton).Assembly,
                    typeof(Toolbar).Assembly,
                    typeof(CardView).Assembly,
                    typeof(DrawerLayout).Assembly,
                    typeof(ViewPager).Assembly,
                    typeof(MvxRecyclerView).Assembly,
                    typeof(MvxSwipeRefreshLayout).Assembly
                };

                return assemblies;
            }
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            Firebase.FirebaseApp.InitializeApp(ApplicationContext);
        }

        public override void InitializeSecondary()
        {
            try
            {
                base.InitializeSecondary();
            }
            catch (Exception e)
            {
                // Since the exception is thrown on a background thread we need to move it to the main thread.
                // On the main thread it makes the app crash as expected
                // This is needed to make the app crash when something goes wrong at AppStart. E.g. MvxIoCResolveException
                var dispatcher = Mvx.IoCProvider.Resolve<IMvxMainThreadAsyncDispatcher>();
                dispatcher.ExecuteOnMainThreadAsync(() => { throw e; });

                throw;
            }
        }
    }
}
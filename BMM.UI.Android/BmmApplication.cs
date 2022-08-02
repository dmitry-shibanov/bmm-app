using System;
using Android.App;
using Android.Runtime;
using BMM.Core;
using MvvmCross.Platforms.Android.Views;

namespace BMM.UI.Droid
{
#if DEBUG
    [Application(Debuggable = true)]
#else
    [Application(Debuggable = false)]
#endif
    public class BmmApplication : MvxAndroidApplication<AndroidSetup, App>
    {
        public static bool RunsUiTest;

        public BmmApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        { }
    }
}
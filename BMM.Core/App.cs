using MvvmCross.ViewModels;

// ReSharper disable RedundantTypeArgumentsOfMethod

namespace BMM.Core
{
    public class App : MvxApplication
    {
        private const string MainAssemblyName = "BMM";

        /// <summary>
        /// Called once at startup to initialize classes and start the app
        /// </summary>
        public override void Initialize()
        {
            RegisterCustomAppStart<AppStart>();
        }
    }
}
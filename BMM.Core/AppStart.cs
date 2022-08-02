using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;

namespace BMM.Core
{
    public class AppStart : MvxAppStart
    {
        public AppStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="hint">Hint contains information in case the app is started with extra parameters</param>
        protected override async Task NavigateToFirstViewModel(object hint = null)
        {
        }
    }
}
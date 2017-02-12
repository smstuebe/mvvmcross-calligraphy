using Android.Content;
using Calligraphy.Droid.Views;
using MvvmCross.Binding.Droid;
using MvvmCross.Calligraphy;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;

namespace Calligraphy.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override MvxAndroidBindingBuilder CreateBindingBuilder()
        {
            return new CalligraphyMvxAndroidBindingBuilder();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}

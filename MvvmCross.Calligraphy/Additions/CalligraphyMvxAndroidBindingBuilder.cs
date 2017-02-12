using MvvmCross.Binding.Droid;
using MvvmCross.Binding.Droid.Binders;

namespace MvvmCross.Calligraphy
{ 
    public class CalligraphyMvxAndroidBindingBuilder : MvxAndroidBindingBuilder
    {
        protected override IMvxAndroidViewBinderFactory CreateAndroidViewBinderFactory()
        {
            return new CalligraphyMvxAndroidViewFactory();
        }
    }
}
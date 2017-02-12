using MvvmCross.Binding.Droid.Binders;

namespace MvvmCross.Calligraphy
{
    public class CalligraphyMvxAndroidViewFactory
        : IMvxAndroidViewBinderFactory
    {
        public virtual IMvxAndroidViewBinder Create(object source)
        {
            return new CalligraphyMvxAndroidViewBinder(source);
        }
    }
}
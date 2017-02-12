using Android.Content;
using Android.Util;
using Android.Views;
using Calligraphy;
using MvvmCross.Binding.Droid.Binders;

namespace MvvmCross.Calligraphy
{
    public class CalligraphyMvxAndroidViewBinder : MvxAndroidViewBinder
    {
        private readonly CalligraphyFactory _factory;

        public CalligraphyMvxAndroidViewBinder(object source) : base((object) source)
        {
            var config = CalligraphyConfig.Get();
            _factory = new CalligraphyFactory(config.AttrId);
        }

        public override void BindView(View view, Context context, IAttributeSet attrs)
        {
            _factory.OnViewCreated(view, context, attrs);
            base.BindView(view, context, attrs);
        }
    }
}
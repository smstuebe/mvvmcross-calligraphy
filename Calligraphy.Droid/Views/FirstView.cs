using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace Calligraphy.Droid.Views
{
    [Activity(Label = "View for FirstViewModel", Theme = "@style/Theme.AppCompat.Light")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
               .SetDefaultFontPath("fonts/Quantico-Regular.ttf")
               .SetFontAttrId(Resource.Attribute.fontPath)
               .DisablePrivateFactoryInjection()
               // Adding a custom view that support adding a typeFace
               // .AddCustomViewWithSetTypeface(Java.Lang.Class.FromType(typeof(CustomViewWithTypefaceSupport)))
               // Adding a custom style
               // .AddCustomStyle(Java.Lang.Class.FromType(typeof(TextField)), Resource.Attribute.textFieldStyle)
               .Build());

            SetContentView(Resource.Layout.FirstView);
        }
    }
}

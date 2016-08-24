using Android.App;
using Android.OS;
using Android.Views;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views;

namespace Autobot.Droid.Views
{
    [Activity(Label = "Rules")]
    public class HomeView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HomeActivity);
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
        }
    }
}
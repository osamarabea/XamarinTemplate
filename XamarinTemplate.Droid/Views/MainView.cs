using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace XamarinTemplate.Droid.Views
{
	[Activity (Label = "MainView", MainLauncher = false, Icon = "@mipmap/icon")]

    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.activity_main);
        }
    }
}
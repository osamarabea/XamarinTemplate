using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace XamarinTemplate.Droid.Views
{
	[Activity (Label = "MainView", MainLauncher = true, Icon = "@mipmap/icon")]

    public class MainView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);
        }
    }
}
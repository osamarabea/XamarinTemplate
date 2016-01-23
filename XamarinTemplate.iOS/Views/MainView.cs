using System;

using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using XamarinTemplate.Core.ViewModels;
using System.Linq.Expressions;
using Accelerate;

namespace XamarinTemplate.iOS
{
	public partial class MainView : MvxViewController
	{
		public MainView() : base ("MainView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			var bindings = this.CreateBindingSet<MainView, MainViewModel> (); 
			bindings.Bind(ViewModelLabel).For(label => label.Text).To(vm => vm.Hello); 
			bindings.Apply();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}



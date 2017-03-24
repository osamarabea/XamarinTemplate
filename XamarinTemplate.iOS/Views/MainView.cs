using System;

using UIKit;
using XamarinTemplate.Core.ViewModels;
using System.Linq.Expressions;
using Accelerate;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

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
			bindings.Bind(ViewModelLabel).For(label => label.Text).To(vm => vm.Title); 
			bindings.Apply();

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}



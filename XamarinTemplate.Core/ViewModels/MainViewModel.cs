using Cirrious.MvvmCross.ViewModels;

namespace XamarinTemplate.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
		private string _title = "Hello MvvmCross";
        public string Title
		{ 
			get { return _title; }
			set { _title = value; RaisePropertyChanged(() => Title); }
		}
    }
}

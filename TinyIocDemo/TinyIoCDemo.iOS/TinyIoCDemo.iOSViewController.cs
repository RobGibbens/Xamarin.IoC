using System;
using MonoTouch.UIKit;
using IoCDemo.Core;

namespace TinyIoCDemo.iOS
{
	public partial class TinyIoCDemo_iOSViewController : UIViewController
	{
		public TinyIoCDemo_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var viewModel = TinyIoC.TinyIoCContainer.Current.Resolve<MainViewModel> ();

			var platformName = viewModel.PlatformName;
			var container = viewModel.ContainerName;
			var userName = viewModel.UserName;
			var password = viewModel.Password;

			Console.WriteLine ("Platform:{0} Container:{1} UserName:{2} Password:{3}", platformName, container, userName, password);

			platformLabel.Text = "Platform : " + platformName;
			containerLabel.Text = "Container : " + container;
			userNameLabel.Text = "UserName : " + userName;
			passwordLabel.Text = "Password : " + password;
		}
	}
}


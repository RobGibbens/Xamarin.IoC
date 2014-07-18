using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using IoCDemo.Core;
using Autofac;

namespace AutoFacDemo.iOS
{
	public partial class AutoFacDemo_iOSViewController : UIViewController
	{
		public AutoFacDemo_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			MainViewModel viewModel = null;

			using (var scope = App.Container.BeginLifetimeScope ()) {
				viewModel = App.Container.Resolve<MainViewModel> ();
			}

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
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using IoCDemo.Core;

namespace UnityDemo.iOS
{
	public partial class UnityDemo_iOSViewController : UIViewController
	{
		public UnityDemo_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			var viewModel = App.Container.Resolve (typeof(MainViewModel), "mainViewModel") as MainViewModel;

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


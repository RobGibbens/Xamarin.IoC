using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Autofac;
using IoCDemo.Core;

namespace AutoFacDemo.Droid
{
	[Activity (Label = "AutoFacDemo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			MainViewModel viewModel = null;

			using (var scope = App.Container.BeginLifetimeScope ()) {
				viewModel = App.Container.Resolve<MainViewModel> ();
			}

			var platformName = viewModel.PlatformName;
			var userName = viewModel.UserName;
			var password = viewModel.Password;
			var container = viewModel.ContainerName;

			Console.WriteLine ("Platform:{0} Container:{1} UserName:{2} Password:{3}", platformName, container, userName, password);

			FindViewById<TextView> (Resource.Id.platformTextView).Text = "Platform : " + platformName;
			FindViewById<TextView> (Resource.Id.containerTextView).Text = "Container : " + container;
			FindViewById<TextView> (Resource.Id.userNameTextView).Text = "UserName : " + userName;
			FindViewById<TextView> (Resource.Id.passwordText).Text = "Password : " + password;
		}
	}
}
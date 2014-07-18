using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Cirrious.CrossCore;
using IoCDemo.Core;

namespace MvvmCrossDemo.Droid
{
	[Activity (Label = "MvvmCrossDemo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);

			var viewModel = Mvx.IocConstruct<MainViewModel> ();

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
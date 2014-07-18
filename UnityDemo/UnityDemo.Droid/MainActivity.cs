using System;
using Android.App;
using Android.Widget;
using Android.OS;
using IoCDemo.Core;

namespace UnityDemo.Droid
{
	[Activity (Label = "UnityDemo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			MainViewModel viewModel = App.Container.Resolve (typeof(MainViewModel), "mainViewModel") as MainViewModel;

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
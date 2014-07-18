using System;
using Android.App;
using Android.Runtime;
using Cirrious.CrossCore;
using IoCDemo.Core;
using Cirrious.CrossCore.IoC;

namespace MvvmCrossDemo.Droid
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
			MvxSimpleIoCContainer.Initialize ();
			Mvx.RegisterType<IPlatform, DroidPlatform> ();
			Mvx.RegisterType<ISettings, DroidSettings> ();

			base.OnCreate();
		}
	}
}
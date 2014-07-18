using System;
using Android.App;
using Android.Runtime;
using Microsoft.Practices.Unity;
using IoCDemo.Core;

namespace UnityDemo.Droid
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public static UnityContainer Container { get; set; }

		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
			App.Container = new UnityContainer();
			App.Container.RegisterType (typeof(IPlatform), typeof(DroidPlatform));
			App.Container.RegisterType (typeof(ISettings), typeof(DroidSettings));

			base.OnCreate();
		}
	}
}
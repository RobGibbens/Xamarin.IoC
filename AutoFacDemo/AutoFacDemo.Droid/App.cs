using System;
using Android.App;
using Android.Runtime;
using Autofac;
using IoCDemo.Core;

namespace AutoFacDemo.Droid
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public static IContainer Container { get; set; }

		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
			var builder = new ContainerBuilder();

			builder.RegisterInstance(new DroidPlatform()).As<IPlatform>();
			builder.RegisterInstance(new DroidSettings()).As<ISettings>();
			builder.RegisterType<MainViewModel> ();

			App.Container = builder.Build ();

			base.OnCreate();
		}
	}
}
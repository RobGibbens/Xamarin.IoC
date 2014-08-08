using System;
using Ninject;
using Android.Runtime;
using Android.App;

namespace NinjectDemo.Droid
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public static IKernel Container { get; set; }

		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
			var kernel = new Ninject.StandardKernel(new NinjectDemoModule());			

			App.Container = kernel;

			base.OnCreate();
		}
	}
}
using System;
using Android.App;
using Android.Runtime;
using TinyIoC;
using IoCDemo.Core;

namespace TinyIoCDemo.Droid
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
			//AutoRegister works, but inspects the code. This is a performance
			//hit every single time the app starts, for the "benefit" of a few
			//seconds of developer time.
			//TinyIoCContainer.Current.AutoRegister();

			var container = TinyIoCContainer.Current;

			container.Register<IPlatform, DroidPlatform> ();
			container.Register<ISettings, DroidSettings> ();

			base.OnCreate();
		}
	}
}
using System;
using Android.App;
using Android.Runtime;
using IoCDemo.Core;
using OpenNETCF.IoC;

namespace OpenNETCFDemo.Droid
{
	[Application(Icon="@drawable/icon", Label="@string/app_name")]
	public class App : Application
	{
		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
		}

		public override void OnCreate()
		{
			RootWorkItem.Services.AddNew<DroidPlatform, IPlatform> ();
			RootWorkItem.Services.AddNew<DroidSettings, ISettings> ();

			base.OnCreate();
		}
	}
}
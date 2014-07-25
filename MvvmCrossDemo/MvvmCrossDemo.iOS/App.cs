using Cirrious.CrossCore;
using IoCDemo.Core;
using Cirrious.CrossCore.IoC;

namespace MvvmCrossDemo.iOS
{
	public static class App
	{
		public static void Initialize ()
		{
			MvxSimpleIoCContainer.Initialize ();
			Mvx.RegisterType<IPlatform, ApplePlatform> ();
			Mvx.RegisterType<ISettings, AppleSettings> ();
		}
	}
}
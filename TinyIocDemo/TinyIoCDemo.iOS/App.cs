using TinyIoC;
using IoCDemo.Core;

namespace TinyIoCDemo.iOS
{
	public static class App
	{
		public static void Initialize ()
		{
			//AutoRegister works, but inspects the code. This is a performance
			//hit every single time the app starts, for the "benefit" of a few
			//seconds of developer time.
			//TinyIoCContainer.Current.AutoRegister();

			var container = TinyIoCContainer.Current;

			container.Register<IPlatform, ApplePlatform> ();
			container.Register<ISettings, AppleSettings> ();
		}
	}
}
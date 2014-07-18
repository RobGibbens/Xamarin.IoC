using IoCDemo.Core;

namespace TinyIoCDemo.Droid
{
	public class DroidPlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "Android";
		}

		public string ContainerName {
			get {
				return "TinyIoC";
			}
		}
	}
}
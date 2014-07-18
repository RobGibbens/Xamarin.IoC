using IoCDemo.Core;

namespace TinyIoCDemo.iOS
{
	public class IOSPlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "iOS";
		}

		public string ContainerName {
			get {
				return "TinyIoC";
			}
		}
	}
}
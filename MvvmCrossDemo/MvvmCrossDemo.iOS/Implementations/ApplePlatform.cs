using IoCDemo.Core;

namespace MvvmCrossDemo.iOS
{
	public class ApplePlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "iOS";
		}

		public string ContainerName {
			get {
				return "MvvmCross";
			}
		}
	}
	
}
using System;
using IoCDemo.Core;

namespace AutoFacDemo.iOS
{
	public class ApplePlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "iOS";
		}

		public string ContainerName {
			get {
				return "AutoFac";
			}
		}
	}
}
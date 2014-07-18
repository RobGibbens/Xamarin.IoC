using System;
using IoCDemo.Core;

namespace AutoFacDemo.iOS
{
	public class IOSPlatform : IPlatform
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
using System;
using IoCDemo.Core;

namespace UnityDemo.iOS
{
	public class ApplePlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "iOS";
		}

		public string ContainerName {
			get {
				return "Unity";
			}
		}
	}
}
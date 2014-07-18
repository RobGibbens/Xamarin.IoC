using System;
using IoCDemo.Core;

namespace OpenNETCFDemo.Droid
{
	public class DroidPlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "Android";
		}

		public string ContainerName {
			get {
				return "OpenNETCF";
			}
		}
	}

}
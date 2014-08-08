using System;
using IoCDemo.Core;

namespace NinjectDemo.Droid
{
	public class DroidPlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "Android";
		}

		public string ContainerName {
			get {
				return "Ninject";
			}
		}
	}
}
using Ninject.Modules;
using IoCDemo.Core;

namespace NinjectDemo.iOS
{
	public class NinjectDemoModule : NinjectModule
	{
		public override void Load()
		{
			this.Bind<IPlatform>().To<ApplePlatform>();
			this.Bind<ISettings> ().To<AppleSettings> ();
		}
	}
}
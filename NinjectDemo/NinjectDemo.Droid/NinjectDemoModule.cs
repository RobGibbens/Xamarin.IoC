using Ninject.Modules;
using IoCDemo.Core;

namespace NinjectDemo.Droid
{
	public class NinjectDemoModule : NinjectModule
	{
		public override void Load()
		{
			this.Bind<IPlatform>().To<DroidPlatform>();
			this.Bind<ISettings> ().To<DroidSettings> ();
		}
	}
}
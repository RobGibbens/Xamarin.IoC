using Autofac;
using IoCDemo.Core;

namespace AutoFacDemo.iOS
{
	public class App
	{
		public static IContainer Container { get; set; }

		public static void Initialize()
		{
			var builder = new ContainerBuilder();

			builder.RegisterInstance(new IOSPlatform()).As<IPlatform>();
			builder.RegisterInstance(new IOSSettings()).As<ISettings>();
			builder.RegisterType<MainViewModel> ();

			App.Container = builder.Build ();
		}
	}
}
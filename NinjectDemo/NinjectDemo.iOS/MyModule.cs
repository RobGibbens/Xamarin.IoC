using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Ninject;
using Ninject.Modules;
using IoCDemo.Core;

namespace Nin.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.

	public class MyModule : NinjectModule
	{
		public override void Load()
		{
			//this.Bind<IDatabase>().To<Clazz>();
		}
	}

}

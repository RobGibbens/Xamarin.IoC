using IoCDemo.Core;

namespace AutoFacDemo.Droid
{
	public class DroidSettings : ISettings
	{
		public string UserName {
			get {
				return "LarryPage@google.com";
			}
		}
		public string Password {
			get {
				return "weAreWatchingYou";
			}
		}
	}
}
using IoCDemo.Core;

namespace MvvmCrossDemo.iOS
{
	public class AppleSettings : ISettings
	{
		public string UserName {
			get {
				return "SteveJobs@apple.com";
			}
		}
		public string Password {
			get {
				return "whyPayLess?";
			}
		}
	}
}
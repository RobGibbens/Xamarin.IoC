using IoCDemo.Core;

namespace TinyIoCDemo.iOS
{
	public class IOSSettings : ISettings
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
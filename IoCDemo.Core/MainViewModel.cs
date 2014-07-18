namespace IoCDemo.Core
{
	public class MainViewModel
	{
		private readonly IPlatform _platform;
		private readonly ISettings _settings;

		public MainViewModel (IPlatform platform, ISettings settings)
		{
			_settings = settings;
			_platform = platform;
		}

		public string PlatformName
		{
			get {
				return _platform.GetPlatformName ();
			}
		}

		public string ContainerName
		{
			get {
				return _platform.ContainerName;
			}
		}

		public string UserName
		{
			get {
				return _settings.UserName;
			}
		}

		public string Password
		{
			get {
				return _settings.Password;
			}
		}
	}
}
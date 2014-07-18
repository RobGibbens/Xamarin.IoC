namespace IoCDemo.Core
{
	public interface IPlatform
	{
		string GetPlatformName ();
		string ContainerName { get; }
	}
}
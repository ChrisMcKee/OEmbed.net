namespace OEmbed.Net.Utilities
{
	using System.IO;

	public interface IRestCall
	{
		Stream Call(string url);
	}
}
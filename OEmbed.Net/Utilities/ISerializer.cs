namespace OEmbed.Net.Utilities
{
	using System.IO;

	public interface ISerializer<T>
	{
		string Serialize(T content);
		T Deserialize(string content);
		T Deserialize(Stream content);
	}
}
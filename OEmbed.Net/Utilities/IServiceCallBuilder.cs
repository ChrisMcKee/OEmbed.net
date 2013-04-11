namespace OEmbed.Net.Utilities
{
	public interface IServiceCallBuilder
	{
		string ApiEndpoint { get; set; }
		ServiceCallBuilder.DataType Type { get; set; }
		string Url { get; set; }
		string ToString();
	}
}
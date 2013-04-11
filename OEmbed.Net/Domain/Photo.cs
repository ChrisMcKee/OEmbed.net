namespace OEmbed.Net.Domain
{
	using System.Runtime.Serialization;

	[DataContract(Name = "oembed")]
	public class Photo : Base
	{
		[DataMember(Name = "url")]
		public string Url { get; set; }

		[DataMember(Name = "width")]
		public int Width { get; set; }

		[DataMember(Name = "height")]
		public int Height { get; set; }
	}
}
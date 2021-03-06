﻿namespace OEmbed.Net.Domain
{
	using System.Runtime.Serialization;

	[DataContract]
	public class Rich : Base
	{
		[DataMember(Name = "html")]
		public string Html { get; set; }

		[DataMember(Name = "width")]
		public string Width { get; set; }

		[DataMember(Name = "height")]
		public string Height { get; set; }
	}
}
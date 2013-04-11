namespace OEmbed.Test
{
	using System.IO;
	using System.Reflection;

	public class Util
	{
		public static Stream GetEmbeddedResource(string assemblyFileName)
		{
			var assembly = Assembly.GetExecutingAssembly();
			return assembly.GetManifestResourceStream(assemblyFileName);
		}
	}
}
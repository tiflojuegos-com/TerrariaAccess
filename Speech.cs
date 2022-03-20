using System.Runtime.InteropServices;
namespace SharpSpeech
{
	public class Speech
	{
		private const string libraryName = "UniversalSpeech.Dll";
		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "speechSay")]
		public static extern int Speak(string str, int interrupt);

		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "brailleDisplay")]
		public static extern int OutputBraille(string str);

		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "speechStop")]
		public static extern int Stop();

		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "speechGetValue")]
		public static extern int queryParameter(SpeechParams what);

		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "speechSetValue")]
		public static extern int SetParameter(SpeechParams what, int value);

		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "speechGetString")]
		public static extern string QueryStringParameter(SpeechParams what);

		[DllImport(libraryName, CharSet = CharSet.Unicode, EntryPoint = "speechSetString")]
		public static extern int SetStringParameter(SpeechParams what, string value);
	}
}
namespace SharpSpeech
{
	/// <summary>
	///Provides an enumerator for Universal Speech Parameters.
	/// </summary>
	public enum SpeechParams
	{
	speechVolume, speechVolumeMin, speechVolumeMax, speechVolumeSupported,
	speechRate, speechRateMin, speechRateMax, speechRateSupported,
	speechPitch, speechPitchMin, speechPitchMax, speechPitchSupported,
	speechInflection, speechInflectionMin, speechInflectionMax, speechInflectionSupported,
	speechPause, speechPauseSupported,
	isSpeechBusy, isSpeechBusySupported,
	speechWaitForFinish, speechWaitForFinishSupported,
	speechEnableSAPI = 0xFFFF,
	speechSapiVoice = 0x10000,
	speechSAPILanguage = 0x20000,
	//Universal Speech provides more parameters but I think that their existence is unnecessary in Windows-only environment.
	
	}
}
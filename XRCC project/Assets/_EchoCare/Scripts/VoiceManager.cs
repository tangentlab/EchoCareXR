using UnityEngine;
using Oculus.Voice;

namespace ECHO
{
	public class VoiceManager : MonoBehaviour
	{
		public AppVoiceExperience appVoice;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		private void Start()
		{
		}

		// Update is called once per frame
		private void Update()
		{
			//check ovrinput for voice command
			if (OVRInput.GetDown(OVRInput.Button.One))
			{
				Debug.Log("-- Voice command triggered.");
				appVoice.Activate();
			}
		}
	}
}
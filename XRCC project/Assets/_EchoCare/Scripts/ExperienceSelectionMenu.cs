using UnityEngine;
using UnityEngine.Timeline;

namespace ECHO
{
	public class ExperienceSelectionMenu : MonoBehaviour
	{
		public TimelineClip timeline;

		private EchoManager echoManager;

		private void Awake()
		{
			echoManager = EchoManager.Instance;
		}

		public void SelectDelayed()
		{
			//print("-- Delayed Recall selected.");
			gameObject.SetActive(false);
			echoManager.StartDelayedRecallTask();
		}

		public void SelectTask2()
		{
			gameObject.SetActive(false);
			echoManager.StartTask2();
		}
	}
}
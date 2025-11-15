using UnityEngine;

namespace ECHO
{
	public class ExcerciseDelayedRecall : MonoBehaviour
	{
		[SerializeField] private AudioClip[] clips;

		private EchoManager echoManager;

		private void Awake()
		{
			//echoManager = EchoManager.Instance;
			//if (echoManager == null)
			//{
			//	Debug.LogError("-- EchoManager instance not found!");
			//}
		}

		internal void StartExercise()
		{
			echoManager = EchoManager.Instance;

			Debug.Log("-- Delayed Recall Exercise Started.");
			echoManager.RevealCompanion();
			echoManager.testTableHandler.ShowDelayedRecall();
		}
	}
}
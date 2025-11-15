using UnityEngine;


namespace ECHO
{
	public class ExcerciseDelayedRecall : MonoBehaviour
	{
		[SerializeField] private AudioClip[] clips;

		private EchoManager echoManager;

		internal void StartExercise()
		{
			Debug.Log("-- Delayed Recall Exercise Started.");
		}

		private void Awake()
		{
			echoManager = EchoManager.Instance;
		}


	}
}
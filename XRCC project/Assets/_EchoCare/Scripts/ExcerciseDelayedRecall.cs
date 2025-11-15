using System;
using UnityEngine;
using UnityEngine.Timeline;

namespace ECHO
{
	public class ExcerciseDelayedRecall : MonoBehaviour
	{
		public AudioClip[] clips;

		public TimelineClip timeline;

		private EchoManager echoManager;

		internal void StartExercise()
		{
			Debug.Log("-- Delayed Recall Exercise Started.");
		}

		private void Awake()
		{
			echoManager = EchoManager.Instance;
		}

		// Update is called once per frame
		private void Update()
		{
		}
	}
}
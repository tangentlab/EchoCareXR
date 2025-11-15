using System;
using UnityEngine;

namespace ECHO
{
	public class ExcercisePathFollowing : MonoBehaviour
	{
		private EchoManager echoManager;

		internal void StartExcercise()
		{
			// show
			echoManager.testTableHandler.ShowPathFollowing();
		}

		private void Awake()
		{
			echoManager = EchoManager.Instance;
		}
	}
}
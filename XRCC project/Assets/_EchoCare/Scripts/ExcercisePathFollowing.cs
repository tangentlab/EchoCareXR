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

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		private void Start()
		{
		}

		// Update is called once per frame
		private void Update()
		{
		}
	}
}
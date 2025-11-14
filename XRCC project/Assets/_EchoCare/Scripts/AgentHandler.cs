using System;
using UnityEngine;

namespace ECHO
{
	public class CompanionHandler : MonoBehaviour
	{
		public AudioClip agentAudioClip;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		private void Start()
		{
			gameObject.SetActive(false);
		}

		// Update is called once per frame
		private void Update()
		{
		}

		private void PlayVoice()
		{
			//agentAudioClip = Resources.Load<AudioClip>("Audio/Agent/starting delayed recall");
			if (agentAudioClip != null)
			{
				// player after a short delay
				AudioSource audioSource = gameObject.AddComponent<AudioSource>();
				audioSource.clip = agentAudioClip;
				audioSource.PlayDelayed(5);
			}
			else
			{
				Debug.LogWarning("Agent audio clip not found in Resources/Audio/Agent/agent_greeting");
			}
		}

		public void PositionInfrontOfUser()
		{
			// Position the companion 2 meters in front of the user
			Transform userTransform = Camera.main.transform;
			Vector3 forward = new Vector3(userTransform.forward.x, 0, userTransform.forward.z).normalized;
			Vector3 targetPosition = userTransform.position + forward * 2.0f; // 2 meters in front

			targetPosition.y = 0; //plane the companion on the ground level

			transform.position = targetPosition;
			transform.LookAt(new Vector3(userTransform.position.x, transform.position.y, userTransform.position.z));
		}

		internal void RevealCompanion()
		{
			//throw new NotImplementedException();
			//PlayVoice();
			gameObject.SetActive(true);
			PositionInfrontOfUser();
		}
	}
}
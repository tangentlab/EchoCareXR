using UnityEngine;

public class AgentHandler : MonoBehaviour
{
	public AudioClip agentAudioClip;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	private void Start()
	{
		PlayVoice();
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

	// Update is called once per frame
	private void Update()
	{
	}
}
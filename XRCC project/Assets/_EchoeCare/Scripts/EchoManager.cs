using UnityEngine;

namespace ECHO
{
	public class EchoManager : MonoBehaviour
	{
		public UserInfo userInfo = new UserInfo();
		public MenuHandler menuHandler;
		public CompanionHandler companionHandler;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		private void Start()
		{
			userInfo = new UserInfo();
			print("EchoManager started.");
			print($"User Name: {userInfo.userName}");

			if (menuHandler != null)
			{
				menuHandler.InitializeMenu();
			}
			else
			{
				Debug.LogWarning("MenuHandler is not assigned in EchoManager.");
			}

			if (companionHandler != null)
			{
				// CompanionHandler will handle its own initialization in Start
				companionHandler.PositionInfrontOfUser();
			}
			else
			{
				Debug.LogWarning("CompanionHandler is not assigned in EchoManager.");
			}
		}
	}
}
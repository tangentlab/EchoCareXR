using UnityEngine;

namespace ECHO
{
	public class EchoManager : MonoBehaviour
	{
		private string userName = "Maria";

		public UserInfo userInfo = new UserInfo();
		public MenuHandler menuHandler;
		public CompanionHandler companionHandler;

		public TestTableHandler testTableHandler;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		private void Start()
		{
			userInfo = new UserInfo(userName);
			print("EchoManager started.");
			print($"User Name: {userInfo.userName}");

			// Initialize Menu
			if (menuHandler != null)
			{
				menuHandler.InitializeMenu();
			}

		}

		public void StartDelayedRecallTask()
		{
			Debug.Log("Starting Delayed Recall Session...");
			// Add logic to start the delayed recall session
			RevealCompanion();
			//desplay table after companion task introduction
			if (testTableHandler != null)
			{
				testTableHandler.DisplayTestTable();
			}


		}

		public void RevealCompanion()
		{
			if (companionHandler != null)
			{
				companionHandler.RevealCompanion();
			}
		}
	}
}
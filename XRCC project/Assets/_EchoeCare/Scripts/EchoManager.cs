using UnityEngine;

namespace ECHO
{
	public class EchoManager : MonoBehaviour
	{
		private string userName = "Maria";

		public MenuHandler menuHandler;
		public CompanionHandler companionHandler;

		[Header("Tasks table")]
		public TestTableHandler testTableHandler;

		private UserInfo userInfo = new UserInfo();

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

			testTableHandler.Hide();
		}

		public void StartDelayedRecallTask()
		{
			Debug.Log("Starting Delayed Recall Session...");
			// Add logic to start the delayed recall session
			RevealCompanion();
			//desplay table after companion task introduction
			if (testTableHandler != null)
			{
				testTableHandler.Show();
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
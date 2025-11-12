using UnityEngine;

namespace ECHO
{
	public class EchoManager : MonoBehaviour
	{
		public UserInfo userInfo = new UserInfo();
		public MenuHandler menuHandler;
		public CompanionHandler companionHandler;

		public TestTableHandler testTableHandler;

		// Start is called once before the first execution of Update after the MonoBehaviour is created
		private void Start()
		{
			userInfo = new UserInfo();
			print("EchoManager started.");
			print($"User Name: {userInfo.userName}");

			// Initialize Menu
			if (menuHandler != null)
			{
				menuHandler.InitializeMenu();
			}


			if (companionHandler != null)
			{
				// CompanionHandler will handle its own initialization in Start
				companionHandler.PositionInfrontOfUser();
			}

			if (testTableHandler != null)
			{
				//testTableHandler.PositionTableInFrontOfUser();
			}
		}
	}
}
using UnityEngine;

namespace ECHO
{
	public class EchoManager : MonoBehaviour
	{
		public UserInfo userInfo = new UserInfo();
		public MenuHandler menuHandler;

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
		}
	}
}
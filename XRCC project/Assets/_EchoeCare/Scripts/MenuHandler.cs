using System;
using UnityEngine;

namespace ECHO
{
	public class MenuHandler : MonoBehaviour
	{
		public GameObject welcomeMenu;
		public GameObject dateMenu;
		public GameObject doNextMenu;



		//hold list of menus

		internal void InitializeMenu()
		{
			// Initialize menu items here
			if (welcomeMenu != null)
			{
				welcomeMenu.SetActive(true);
			}
			else
			{
				Debug.LogWarning("WelcomeMenu is not assigned in MenuHandler.");
			}

			if (dateMenu != null)
			{
				dateMenu.SetActive(false);
			}
			else
			{
				Debug.LogWarning("MainMenu is not assigned in MenuHandler.");
			}

		}
	}
}
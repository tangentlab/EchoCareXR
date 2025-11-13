using System;
using UnityEngine;

namespace ECHO
{
	public class MenuHandler : MonoBehaviour
	{
		public GameObject welcomeMenu;
		public GameObject dateMenu;
		public GameObject doNextMenu;

		public float welcomeMenuDuration = 5f;

		//hold list of menus

		internal void InitializeMenu()
		{
			// Initialize menu items here
			if (welcomeMenu) welcomeMenu.SetActive(true);

			if (dateMenu) dateMenu.SetActive(false);
			if (doNextMenu) doNextMenu.SetActive(false);

			// hide welcome menu after 5 seconds and show date menu
			Invoke(nameof(ShowDateMenu), welcomeMenuDuration);
		}

		private void ShowDateMenu()
		{
			welcomeMenu.SetActive(false);
			dateMenu.SetActive(true);
		}
	}
}
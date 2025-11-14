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
			//PostitionMenuInFront();

			if (dateMenu) dateMenu.SetActive(false);
			if (doNextMenu) doNextMenu.SetActive(false);

			// hide welcome menu after 5 seconds and show date menu
			Invoke(nameof(ShowDateMenu), welcomeMenuDuration);
		}

		private void PostitionMenuInFront()
		{
			//position menu in front of user

			const float dist = 1.0f;
			Transform userTransform = Camera.main.transform;
			Vector3 forward = new Vector3(userTransform.forward.x, 0, userTransform.forward.z).normalized;
			Vector3 targetPosition = userTransform.position + forward * dist; // 2 meters in front

			targetPosition.y = userTransform.position.y; //plane the companion on the ground level

			transform.position = targetPosition;
			transform.LookAt(new Vector3(userTransform.position.x, transform.position.y, userTransform.position.z));
		}

		private void ShowDateMenu()
		{
			welcomeMenu.SetActive(false);
			dateMenu.SetActive(true);
		}
	}
}
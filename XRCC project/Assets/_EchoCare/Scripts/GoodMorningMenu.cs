using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ECHO
{
    public class GoodMorningMenu : MonoBehaviour
    {
        public TextMeshProUGUI welcomeText;
        public TextMeshProUGUI dateText;


        // define action for public trigger
        public UnityEvent menuAction;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            UpdateText();
        }

        private void UpdateText()
        {
            //update welcome text
            if (welcomeText != null)
            {
                welcomeText.text = "Good Morning, " + PlayerPrefs.GetString("UserName", "User") + "!";
            }

            //update date text
            if (dateText != null)
            {
                dateText.text = $"Today is {System.DateTime.Now.ToString("MMMM dd")}";
            }
        }

        public void OnStartDayButtonPressed()
        {
            // Logic to start the day
            Debug.Log("Start Day button pressed.");
            menuAction?.Invoke();
        }


    }

}
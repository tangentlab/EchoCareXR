using TMPro;
using UnityEngine;

public class WelcomeMenu : MonoBehaviour
{
    public TextMeshProUGUI helloText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (helloText != null)
        {
            helloText.text = "Hello, " + PlayerPrefs.GetString("UserName", "Maria") + "!";
        }
    }

}

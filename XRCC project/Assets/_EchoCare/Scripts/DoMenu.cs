using UnityEngine;
using UnityEngine.Events;

namespace ECHO
{
    public class DoMenu : MonoBehaviour
    {
        public UnityEvent menuAction;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        public void OnMenuButtonPressed()
        {
            // Logic to handle menu button press
            Debug.Log("Menu button pressed.");
            menuAction?.Invoke();
        }
    }
}

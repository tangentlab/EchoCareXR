using UnityEngine;
using UnityEngine.Events;

namespace ECHO
{
    public class DoMenu : MonoBehaviour
    {
        public UnityEvent menuAction;



        public void OnMenuButtonPressed()
        {
            // Logic to handle menu button press
            Debug.Log("Menu button pressed.");
            menuAction?.Invoke();
        }
    }
}

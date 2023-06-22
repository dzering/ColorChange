using UnityEngine;
using UnityEngine.UI;

namespace ColoringApp.Scripts
{
    public class CloseButton : MonoBehaviour
    {
        private void Awake()
        {
            Button button = GetComponent<Button>();
            button.onClick.AddListener(Quit);
        }

        private void Quit() => 
            Application.Quit();
    }
}

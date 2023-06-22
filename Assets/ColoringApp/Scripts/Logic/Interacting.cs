using UnityEngine;

namespace ColoringApp.Scripts
{
    public class Interacting : MonoBehaviour
    {
        private void Update()
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.TryGetComponent(out InteractableBase interactable))
                    interactable.Interact();
            }
        }
    }
}
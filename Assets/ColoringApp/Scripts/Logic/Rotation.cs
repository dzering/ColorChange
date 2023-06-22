using UnityEngine;

namespace ColoringApp.Scripts
{
    public class Rotation : MonoBehaviour
    {
        [Range(20,200)]
        [SerializeField] private float _speedRotation = 1000;
    
        private void Update() => 
            transform.Rotate(0, _speedRotation*Time.deltaTime, 0);
    }
}
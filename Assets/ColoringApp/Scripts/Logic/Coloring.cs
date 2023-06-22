using UnityEngine;

namespace ColoringApp.Scripts
{
    public class Coloring : InteractableBase
    {
        private Material _material;
        private void Awake() => 
            _material = GetComponent<MeshRenderer>().material;

        public override void Interact() => 
            ChangeColor();

        private void ChangeColor() => 
            _material.color = 
                new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
}
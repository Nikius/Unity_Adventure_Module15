using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Hero: MonoBehaviour
    {
        private const KeyCode UseKeyCode = KeyCode.F;
        
        private Consumable _currentConsumable = null;
        
        public bool IsHasConsumable() => _currentConsumable is not null;

        public void PickUpConsumable(Consumable consumable)
        {
            if (IsHasConsumable())
            {
                Debug.Log(gameObject.name + " is already has consumable");
                
                return;
            }
            
            consumable.transform.SetParent(transform);
            _currentConsumable = consumable;
        }

        private void Update()
        {
            if (Input.GetKeyDown(UseKeyCode))
            {
                Consume();
            }
        }

        private void Consume()
        {
            if (IsHasConsumable() == false)
            {
                Debug.Log(gameObject.name + " has no consumable");
                
                return;
            }
            
            _currentConsumable.Consume(this);
            Destroy(_currentConsumable.gameObject);
            _currentConsumable = null;
        }
    }
}
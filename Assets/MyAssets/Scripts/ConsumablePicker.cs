using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class ConsumablePicker: MonoBehaviour
    {
        private Inventory _inventory;
        private void Awake()
        {
            _inventory = GetComponent<Inventory>();

            if (_inventory == null)
            {
                Debug.Log("This object should has Inventory");
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Item item = other.GetComponent<Item>();

            if (_inventory is not null && item is not null && _inventory.IsHasItem() == false)
                _inventory.StoreItem(item);
        }
    }
}
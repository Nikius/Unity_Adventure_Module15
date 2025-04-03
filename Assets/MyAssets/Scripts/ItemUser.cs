using UnityEngine;

namespace MyAssets.Scripts
{
    public class ItemUser: MonoBehaviour
    {
        private Inventory _inventory;

        private void Awake()
        {
            _inventory = GetComponent<Inventory>();
        }
        
        public void Use()
        {
            if (_inventory.IsHasItem() == false)
            {
                Debug.Log(gameObject.name + " has no item");
                
                return;
            }
            
            Item item = _inventory.GetItem();
            item.Use(gameObject);
            _inventory.RemoveItem();
        }
    }
}
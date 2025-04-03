using UnityEngine;

namespace MyAssets.Scripts
{
    public class Inventory: MonoBehaviour
    {
        private Item _item;
        
        public Item GetItem() => _item;
        
        public void StoreItem(Item item)
        {
            if (IsHasItem())
            {
                Debug.Log("Inventory is full");
                
                return;
            }
            
            item.transform.SetParent(transform);
            _item = item;
        }
        
        public bool IsHasItem() => _item is not null;

        public void RemoveItem()
        {
            Destroy(_item.gameObject);
            _item = null;
        }
    }
}
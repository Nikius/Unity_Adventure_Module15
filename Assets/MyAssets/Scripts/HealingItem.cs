using UnityEngine;

namespace MyAssets.Scripts
{
    public class HealingItem: Item
    {
        [SerializeField] private float _healingValue;
        
        public override void Use(GameObject user)
        {
            Health health = user.GetComponent<Health>();

            if (health is not null)
            {
                health.Heal(_healingValue);
            }
            else
            {
                Debug.LogWarning($"{user.name} should have a Health component attached to it");
                
                return;
            }

            base.Use(user);
        }
    }
}
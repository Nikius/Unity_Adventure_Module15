using UnityEngine;

namespace MyAssets.Scripts
{
    public class HealingItem: Consumable
    {
        [SerializeField] private float _healingValue;
        
        public override void Consume(Hero hero)
        {
            Health health = hero.GetComponent<Health>();
            
            if (health != null)
                health.Heal(_healingValue);
            else
                Debug.LogWarning($"{hero.name} should have a Health component attached to it");
            
            base.Consume(hero);
        }
    }
}
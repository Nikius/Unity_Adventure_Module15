using UnityEngine;

namespace MyAssets.Scripts
{
    public class AccelerationItem: Consumable
    {
        [SerializeField] private float _accelerationValue;
        
        public override void Consume(Hero hero)
        {
            Movement movement = hero.GetComponent<Movement>();

            if (movement is not null)
                movement.Accelerate(_accelerationValue);
            else
                Debug.LogWarning($"{hero.name} should have a Movement component attached to it");
            
            base.Consume(hero);
        }
    }
}
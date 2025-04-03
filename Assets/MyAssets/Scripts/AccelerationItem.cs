using UnityEngine;

namespace MyAssets.Scripts
{
    public class AccelerationItem: Item
    {
        [SerializeField] private float _accelerationValue;
        
        public override void Use(GameObject user)
        {
            Movement movement = user.GetComponent<Movement>();

            if (movement is not null)
            {
                movement.Accelerate(_accelerationValue);
            }
            else
            {
                Debug.LogWarning($"{user.name} should have a Movement component attached to it");
                
                return;
            }

            base.Use(user);
        }
    }
}
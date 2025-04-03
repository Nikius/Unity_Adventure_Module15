using UnityEngine;

namespace MyAssets.Scripts
{
    public class Health: MonoBehaviour
    {
        [SerializeField] private float _health;

        public void Heal(float amount)
        {
            if (amount <= 0)
            {
                Debug.Log("Healing amount should be greater than 0");
                
                return;
            }
            
            _health += amount;
            
            Debug.Log($"Current health: {_health}");
        }
    }
}
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Movement: MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        public void Move(Vector3 direction)
        {
            transform.position += direction.normalized * (_speed * Time.deltaTime);
        }
        
        public void Accelerate(float additionalSpeed)
        {
            if (additionalSpeed <= 0)
            {
                Debug.Log("AdditionalSpeed value should be above zero.");
                return;
            }

            _speed += additionalSpeed;
            
            Debug.Log("Current speed: " + _speed);
        }
    }
}
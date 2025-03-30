using UnityEngine;

namespace MyAssets.Scripts
{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;
    
        public void RotateTo(Vector3 direction)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            float step = _rotationSpeed * Time.deltaTime;
        
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
        }
    }
}

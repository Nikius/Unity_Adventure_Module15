using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Bullet: MonoBehaviour
    {
        private Movement _movement;
        private Vector3 _direction;
        
        public void SetDirection(Vector3 direction) => _direction = direction;
        
        private void Awake()
        {
            _movement = GetComponent<Movement>();
        }

        private void Update()
        {
            _movement.Move(_direction);
        }
    }
}
using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class InputMovement : MonoBehaviour
    {
        private const string HorizontalAxis = "Horizontal";
        private const string VerticalAxis = "Vertical";
        private const float MinMove = 0.05f;
        
        private Movement _movement;
        private Rotation _rotation;

        private void Awake()
        {
            _movement = GetComponent<Movement>();
            _rotation = GetComponent<Rotation>();
        }

        private void Update()
        {
            var direction = GetDirection();

            if (direction.magnitude >= MinMove)
            {
                _movement.Move(direction);
                _rotation.RotateTo(direction);
            }
        }

        private static Vector3 GetDirection()
        {
            float inputX = Input.GetAxis(HorizontalAxis);
            float inputZ = Input.GetAxis(VerticalAxis);

            return new Vector3(inputX, 0, inputZ);
        }
    }
}

using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class Hero: MonoBehaviour
    {
        private const KeyCode UseKeyCode = KeyCode.F;
        
        private ItemUser _itemUser;

        private void Awake()
        {
            _itemUser = GetComponent<ItemUser>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(UseKeyCode))
            {
                _itemUser.Use();
            }
        }
    }
}
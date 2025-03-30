using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public class ConsumablePicker: MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Hero hero = other.GetComponent<Hero>();
            Consumable consumable = GetComponent<Consumable>();

            if (hero != null && consumable != null && hero.IsHasConsumable() == false)
                hero.PickUpConsumable(consumable);
        }
    }
}
using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public abstract class Item : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _particleSystemPrefab;

        public virtual void Use(GameObject user)
        {
            ShowParticles();
        }

        private void ShowParticles()
        {
            ParticleSystem blowVFX = Instantiate(_particleSystemPrefab, transform.position, Quaternion.identity);
            blowVFX.Play();
            Destroy(blowVFX, blowVFX.main.duration);
        }
    }
}

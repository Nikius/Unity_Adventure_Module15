using System;
using UnityEngine;

namespace MyAssets.Scripts
{
    public abstract class Consumable : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _particleSystemPrefab;

        public virtual void Consume(Hero hero)
        {
            ShowParticles();
        }

        private void ShowParticles()
        {
            ParticleSystem blow = Instantiate(_particleSystemPrefab, transform.position, Quaternion.identity);
            blow.Play();
            Destroy(blow, blow.main.duration);
        }
    }
}

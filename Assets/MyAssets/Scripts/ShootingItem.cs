using UnityEngine;

namespace MyAssets.Scripts
{
    public class ShootingItem: Consumable
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private float _bulletLifeTime;
        
        public override void Consume(Hero hero)
        {
            Bullet bullet = Instantiate(_bulletPrefab, hero.transform.position, Quaternion.identity);
            bullet.SetDirection(hero.transform.forward);
            
            Destroy(bullet, _bulletLifeTime);
            
            base.Consume(hero);
        }
    }
}
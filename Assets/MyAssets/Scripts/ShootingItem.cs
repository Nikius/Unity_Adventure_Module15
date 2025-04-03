using UnityEngine;

namespace MyAssets.Scripts
{
    public class ShootingItem: Item
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private float _bulletLifeTime;
        
        public override void Use(GameObject user)
        {
            Bullet bullet = Instantiate(_bulletPrefab, user.transform.position, Quaternion.identity);
            bullet.SetDirection(user.transform.forward);
            
            Destroy(bullet, _bulletLifeTime);
            
            base.Use(user);
        }
    }
}
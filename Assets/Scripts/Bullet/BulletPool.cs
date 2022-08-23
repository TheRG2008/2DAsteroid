using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

public class BulletPool
{
    private readonly Dictionary<string, HashSet<Bullet>> _bulletPool;
    private readonly int _capacityPool;
    private Transform _rootPool;
    private string _bulletType;

    public BulletPool(int capacityPool)
    {
        _bulletPool = new Dictionary<string, HashSet<Bullet>>();
        _capacityPool = capacityPool;
        if (!_rootPool)
        {
            _rootPool = new GameObject(NameManager.POOL_BULLET).transform;
        }
    }

    public Bullet GetBull(string type)
    {
        _bulletType = type;
        Bullet result;
        result = GetBullet(GetListBullet(type));
        //switch (type)
        //{
        //    case "StartBullet":
        //        result = GetBullet(GetListBullet(type));           
        //        break;
        //    case "FireballBlueBig":
        //        result = GetBullet(GetListBullet(type));
        //        break;
        //    default:
        //        throw new ArgumentOutOfRangeException(nameof(type), type, "Не предусмотрен в программе");
        //}
        return result;
    }

    private HashSet<Bullet> GetListBullet(string type)
    {
        return _bulletPool.ContainsKey(type) ? _bulletPool[type] : _bulletPool[type] = new HashSet<Bullet>();
    }

    private Bullet GetBullet(HashSet<Bullet> bullets)
    {
        var bullet = bullets.FirstOrDefault(a => !a.gameObject.activeSelf);
        if (bullet == null)
        {
            var laser = Resources.Load<StartBullet>($"Bullets/{_bulletType}");
            for (var i = 0; i < _capacityPool; i++)
            {
                var instantiate = Object.Instantiate(laser);
                instantiate.gameObject.AddComponent<Rigidbody2D>();
                ReturnToPool(instantiate.transform);
                bullets.Add(instantiate);
            }
            GetBullet(bullets);
        }
        bullet = bullets.FirstOrDefault(a => !a.gameObject.activeSelf);
        return bullet;
    }

    private void ReturnToPool(Transform transform)
    {
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        transform.gameObject.SetActive(false);
        transform.SetParent(_rootPool);
    }

    public void RemovePool()
    {
        Object.Destroy(_rootPool.gameObject);
    }
}

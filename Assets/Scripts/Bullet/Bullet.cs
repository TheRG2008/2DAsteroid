using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _damage;
    private object _bulletSprite;
    private float _force;
    private Transform _rotPool;
    private bool _bullLifeTime;
    public float Damage
    {
        get => _damage;
        set => _damage = value;
    }
    public object BulletSprite
    {
        get => _bulletSprite;
        set => _bulletSprite = value;
    }
    public float Force
    {
        get => _force;
        set => _force = value;
    }

    public Transform RotPool
    {
        get
        {
            if (_rotPool == null)
            {
                var find = GameObject.Find(NameManager.POOL_BULLET);
                _rotPool = find == null ? null : find.transform;
            }
            return _rotPool;
        }
    }

    public bool BullLifeTime 
    { 
        get => _bullLifeTime;
        set 
        {
            _bullLifeTime = value;
            if (!_bullLifeTime)
            {
                ReturnToPool();
            }
        } 
    }

    public void ActiveBullet(Vector3 position, Quaternion rotation)
    {
        transform.localPosition = position;
        transform.localRotation = rotation;
        gameObject.SetActive(true);
        transform.SetParent(null);
    }

    private void ReturnToPool()
    {
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
        gameObject.SetActive(false);
        transform.SetParent(RotPool);

        if (!RotPool)
        {
            Destroy(gameObject);
        }

    }
}

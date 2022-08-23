using UnityEngine;

public class Fire : MonoBehaviour
{
    private BulletPool _bulletPool;
    private Bullet _bullet;
    private Player _player;
    private Transform _gun1;
    private Transform _gun2;
    private bool _activeGun = true;
    private float _force = 800;
    private string _buletTypeLevelOne;
    private string _buletTypeLevelTwo;
    private string _buletTypeLevelThree;
    private float _pointForBulletUpgradeLevelOne;
    private float _pointForBulletUpgradeLevelTwo;
    private string _pull;
    

    void Start()
    {
        CreateBulletPull(_buletTypeLevelOne);
        _player = GetComponent<Player>();
        _gun1 = transform.GetChild(0);
        _gun2 = transform.GetChild(1);
    }

    
    void Update()
    {
        GetFire();
    }

    private void BulletTypeUpdate()
    {
        
        if(_player.CurrentPoint == _pointForBulletUpgradeLevelOne)
        {
            CreateBulletPull(_buletTypeLevelTwo);
            _player.CurrentPoint += 10;
        }

        if(_player.CurrentPoint == _pointForBulletUpgradeLevelTwo)
        {
            CreateBulletPull(_buletTypeLevelThree);
        }
    }
    public void AddPointForUpgrade(float one, float two)
    {
        _pointForBulletUpgradeLevelOne = one;
        _pointForBulletUpgradeLevelTwo = two;
        
    }

    public void AddBulletType(string one, string two, string three)
    {
        _buletTypeLevelOne = one;
        _buletTypeLevelTwo = two;
        _buletTypeLevelThree = three;
    }

    public void CreateBulletPull(string pull)
    {
        if(_bulletPool != null)
        {
            _bulletPool.RemovePool();
        }
        _pull = pull;
        _bulletPool = new BulletPool(20);
        
    }
    public void GetFire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _bullet = _bulletPool.GetBull(_pull);

            if (_activeGun)
            {
                _bullet.transform.position = _gun1.position;
                _activeGun = false;
                
            }
            else
            {
                _bullet.transform.position = _gun2.position;
                _activeGun = true;
                
            }
            _player.CurrentPoint = _player.CurrentPoint + 10;
           
            Rigidbody2D _bulletRB = _bullet.gameObject.GetComponent<Rigidbody2D>();
            _bullet.gameObject.SetActive(true);
            _bulletRB.AddForce(_gun1.up * _force);

            BulletTypeUpdate();

            //if (_player.PointForUpgrade <= 0)
            //{
            //    _bulletPool.RemovePool();
            //    _bulletPool = new BulletPool(20);
            //    _bullet = _bulletPool.GetBull("FireballBlueBig");
            //    _player.PointForUpgrade = 10;
            //}
        }
    }
}

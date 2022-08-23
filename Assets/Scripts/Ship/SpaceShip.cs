using UnityEngine;

public class SpaceShip
{
    private GameObject _currentSpaceShip;
    private float _hp;
    private float _maxHP;
    private float _pointForUpgrade;
    private float _speed;
    private float _acceleration;
    private float _pointForBulletUpgradeLevelOne;
    private float _pointForBulletUpgradeLevelTwo;    
    private string _buletTypeLevelOne;
    private string _buletTypeLevelTwo;
    private string _buletTypeLevelThree;


    public GameObject CurrentSpaceShip 
    { 
        get => _currentSpaceShip; 
        set => _currentSpaceShip = value; 
    }
    public float Hp 
    { 
        get => _hp; 
        set => _hp = value;
    }
    public float MaxHP 
    { 
        get => _maxHP;
        set => _maxHP = value; 
    }
    public float PointForUpgrade 
    { 
        get => _pointForUpgrade; 
        set => _pointForUpgrade = value; 
    }
    public float Speed 
    { 
        get => _speed; 
        set => _speed = value; 
    }
    public float Acceleration 
    { 
        get => _acceleration; 
        set => _acceleration = value; 
    }

    public float PointForBulletUpgradeLevelOne
    {
        get => _pointForBulletUpgradeLevelOne;
        set => _pointForBulletUpgradeLevelOne = value;
    }
    public float PointForBulletUpgradeLevelTwo 
    { 
        get => _pointForBulletUpgradeLevelTwo; 
        set => _pointForBulletUpgradeLevelTwo = value; 
    }
    
    public string BuletTypeLevelOne 
    { 
        get => _buletTypeLevelOne; 
        set => _buletTypeLevelOne = value; 
    }
    public string BuletTypeLevelTwo 
    { 
        get => _buletTypeLevelTwo; 
        set => _buletTypeLevelTwo = value; 
    }
    public string BuletTypeLevelThree 
    { 
        get => _buletTypeLevelThree; 
        set => _buletTypeLevelThree = value; 
    }

    public void GetDamage(float damage)
    {
        _hp = _hp - damage;
        if (_hp < _maxHP)
        {
            Debug.Log("Game Over");
        }
    }
}

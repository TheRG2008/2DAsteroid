using UnityEngine;

public sealed class SpaceShipOne : SpaceShip
{
    private GameObject _spaseShip;
    private const float _hp = 10;
    private const float _maxHP = 10;
    private const float _pointForUpgrade = 1000;
    private const float _speed = 4;
    private const float _acceleration = 3;
    private const float _pointForBulletUpgradeLevelOne = 300;
    private const float _pointForBulletUpgradeLevelTwo = 700;
    
    private const string _buletTypeLevelOne = "FireballRedSmall";
    private const string _buletTypeLevelTwo = "FireballRedMed";
    private const string _buletTypeLevelThree = "FireballRedBig";

    public SpaceShipOne ()
    {
        _spaseShip = Resources.Load("SpaseShips/SpaceShipOne") as GameObject;
        CurrentSpaceShip = _spaseShip;
        Hp = _hp;
        MaxHP = _maxHP;
        PointForUpgrade = _pointForUpgrade;
        Speed = _speed;
        Acceleration = _acceleration;
        PointForBulletUpgradeLevelOne = _pointForBulletUpgradeLevelOne;
        PointForBulletUpgradeLevelTwo = _pointForBulletUpgradeLevelTwo;        
        BuletTypeLevelOne = _buletTypeLevelOne;
        BuletTypeLevelTwo = _buletTypeLevelTwo;
        BuletTypeLevelThree = _buletTypeLevelThree;
    }
  
}

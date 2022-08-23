using UnityEngine;

public class SpaceShipTwo : SpaceShip
{
    private GameObject _spaseShip;
    private float _hp = 20;
    private float _maxHP = 20;
    private float _pointForUpgrade = 3000;
    private float _speed = 5;
    private float _acceleration = 4;
    private const float _pointForBulletUpgradeLevelOne = 1500;
    private const float _pointForBulletUpgradeLevelTwo = 2000;
    private const float _pointForBulletUpgradeLevelThree = 2500;
    public SpaceShipTwo()
    {
        _spaseShip = Resources.Load("SpaseShips/SpaceShipTwo") as GameObject;
        CurrentSpaceShip = _spaseShip;
        Hp = _hp;
        MaxHP = _maxHP;
        PointForUpgrade = _pointForUpgrade;
        Speed = _speed;
        Acceleration = _acceleration;
        PointForBulletUpgradeLevelOne = _pointForBulletUpgradeLevelOne;
        PointForBulletUpgradeLevelTwo = _pointForBulletUpgradeLevelTwo;
        
    }

}

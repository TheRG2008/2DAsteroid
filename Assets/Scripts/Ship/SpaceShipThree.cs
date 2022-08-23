using UnityEngine;

public class SpaceShipThree : SpaceShip
{
    private GameObject _spaseShip;
    private float _hp = 30;
    private float _maxHP = 30;
    private float _pointForUpgrade = 7000;
    private float _speed = 4;
    private float _acceleration = 6;
    private const float _pointForBulletUpgradeLevelOne = 4000;
    private const float _pointForBulletUpgradeLevelTwo = 5000;
    private const float _pointForBulletUpgradeLevelThree = 6000;
    public SpaceShipThree()
    {
        _spaseShip = Resources.Load("SpaseShips/SpaceShipThree") as GameObject;
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

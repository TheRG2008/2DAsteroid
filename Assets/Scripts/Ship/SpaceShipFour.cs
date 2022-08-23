using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipFour : SpaceShip
{
    private GameObject _spaseShip;
    private float _hp = 50;
    private float _maxHP = 50;
    private float _pointForUpgrade = 15000;
    private float _speed = 6;
    private float _acceleration = 6;
    private const float _pointForBulletUpgradeLevelOne = 9000;
    private const float _pointForBulletUpgradeLevelTwo = 12000;
    private const float _pointForBulletUpgradeLevelThree = 13000;
    public SpaceShipFour()
    {
        _spaseShip = Resources.Load("SpaseShips/SpaceShipFour") as GameObject;
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

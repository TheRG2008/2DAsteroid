using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private EnemyList _enemyList;
    [SerializeField] private List<Transform> _enemyTransform;
    private int _shipLevel = 1;
    private Player _player;
    private Fire _fire;
    private AsteroidFactory _asteroidFactory;

    private void Start()
    {
        _asteroidFactory = new AsteroidFactory();
    }
    public void StartShipCreate()
    {
        
        var SpaceShip = StaticShipFactory.CreateShip(_shipLevel);
        var ShipCurrent = Instantiate(SpaceShip.CurrentSpaceShip, _transform);
        var gameObjectBuilder = new GameObjectBuilder(ShipCurrent);
        ShipCurrent = gameObjectBuilder.Physics
            .Rigidbody2D(5, false)
            .BoxCollider2D();

        _player = ShipCurrent.AddComponent<Player>();
        _player.AddParametrs(
            SpaceShip.Hp, 
            SpaceShip.MaxHP, 
            SpaceShip.PointForUpgrade, 
            SpaceShip.Speed, 
            SpaceShip.Acceleration 
            );
        _fire = ShipCurrent.AddComponent<Fire>();
        _fire.AddBulletType(
            SpaceShip.BuletTypeLevelOne, 
            SpaceShip.BuletTypeLevelTwo, 
            SpaceShip.BuletTypeLevelThree
            );
        _fire.AddPointForUpgrade(
            SpaceShip.PointForBulletUpgradeLevelOne, 
            SpaceShip.PointForBulletUpgradeLevelTwo
            );
    }

    public void CreateEnemy()
    {
        var asteroid = _asteroidFactory.Create(EnemyType.SmallAsteroid, _enemyList);
        //Instantiate(asteroid, _enemyTransform[Random.Range(0, _enemyTransform.Count)]);

    }

}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class EnemyList : MonoBehaviour
{
    [SerializeField] private List<IEnemy> _smallAsteroids;
    [SerializeField] private List<IEnemy> _mediumAsteroids;
    [SerializeField] private List<IEnemy> _bigAsteroids;

    public IEnemy GetAsteroid(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.SmallAsteroid:
                return RandomAsteroid(_smallAsteroids);                
            case EnemyType.MediumAsteroid:
                return RandomAsteroid(_mediumAsteroids);                
            case EnemyType.BigAsteroid:
                return RandomAsteroid(_bigAsteroids);                
            default:
                return null;                
        }

    }

    private IEnemy RandomAsteroid(List<IEnemy> asteroidType) 
    {
        return asteroidType[Random.Range(0, asteroidType.Count - 1)];
    }
}

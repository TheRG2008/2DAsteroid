using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    private float _hp;
    private float _damage;
    public float HP 
    { 
        get => _hp;
        set 
        {
            _hp = value;
            if (_hp <= 0)
                DestroyAsteroid();
        } 
    }
    public float Damage
    {
        get => _damage;
        set => _damage = value;
    }

    public virtual void DestroyAsteroid()
    {
        Destroy(gameObject);
    }

    public void Move()
    {
        
    }
    public void GetDamage()
    {

    }
    public void TakeDamage(float damage)
    {
        HP -= damage;
    }
}

public interface IEnemyFactory
{
    IEnemy Create(EnemyType enemyType, EnemyList enemyList);
}

public class AsteroidFactory : IEnemyFactory
{
    
    public IEnemy Create(EnemyType enemyType, EnemyList enemyList)
    {
        return enemyList.GetAsteroid(enemyType);
    }
}

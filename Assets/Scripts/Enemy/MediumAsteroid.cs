using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumAsteroid : Enemy
{
    private float _hp = 10;
    private float _damage = 1;

    public MediumAsteroid()
    {
        HP = _hp;
        Damage = _damage;
    }

    public override void DestroyAsteroid()
    {
        base.DestroyAsteroid();
    }
}

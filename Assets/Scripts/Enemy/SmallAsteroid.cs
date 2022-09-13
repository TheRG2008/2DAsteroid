using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SmallAsteroid : Enemy
{
    private float _hp = 10;
    private float _damage = 1;

    public SmallAsteroid ()
    {
        HP = _hp;
        Damage = _damage;
    }

    public override void DestroyAsteroid()
    {
        base.DestroyAsteroid();
    }

}

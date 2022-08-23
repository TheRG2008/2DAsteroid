using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBullet : Bullet
{
    private void Update()
    {
        StartCoroutine("BullLifeTimer");
    }

    private IEnumerator BullLifeTimer()
    {
        yield return new WaitForSeconds(2);
        BullLifeTime = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : DetectionCompatible
{
    [SerializeField]
    private Movement _movement;

    public override void ToLaunchOnDetection(Enemy enemyDetetcted)
    {
        enemyDetetcted.EnemyLife.DecreaseHp(2);
        Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        _movement.SimpleMovement(transform.forward);
    }
}

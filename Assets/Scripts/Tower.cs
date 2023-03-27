using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : DetectionCompatible
{

    private List<Enemy> _enemiesOnSight;
    public Bullet _bulletPrefab;

    private void Start()
    {
        _enemiesOnSight = new List<Enemy>();
        StartCoroutine(InflictDamage());
    }

    public override void ToLaunchOnDetection(Enemy enemyDetected)
    {
        _enemiesOnSight.Add(enemyDetected);
    }

    public override void ToLaunchOnDetectionEnd(Enemy enemyDetetcted)
    {
        _enemiesOnSight.Remove(enemyDetetcted);
    }


    //Temporaire
    private IEnumerator InflictDamage()
    {
        while (true)
        {
            yield return new WaitUntil(DoIHaveAValidEnemy);

            var targetedEnnemy = _enemiesOnSight[0];
            
            var bullet = Instantiate(_bulletPrefab);

            bullet.transform.LookAt(targetedEnnemy .transform,Vector3.up);
            if (targetedEnnemy .EnemyLife.IsDead())
            {
                _enemiesOnSight.Remove(targetedEnnemy);
                Destroy(targetedEnnemy.gameObject);
            }

            yield return new WaitForSeconds(0.5f);
        }
        yield break;
    }

    private bool DoIHaveAValidEnemy()
    {
        return _enemiesOnSight != null && _enemiesOnSight.Count > 0;
    }
}

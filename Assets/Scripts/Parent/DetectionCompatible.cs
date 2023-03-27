using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCompatible : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        var enemyComponent = other.GetComponent<Enemy>();
        if (enemyComponent!=null)
        {
            ToLaunchOnDetection(enemyComponent);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var enemyComponent = other.GetComponent<Enemy>();
        if (enemyComponent!=null)
        {
            ToLaunchOnDetectionEnd(enemyComponent);
        }
    }

    public virtual void ToLaunchOnDetection(Enemy enemyDetetcted)
    {
       //DoStuff
       Debug.Log("I Just detected Something");
    }
    
    public virtual void ToLaunchOnDetectionEnd(Enemy enemyDetetcted)
    {
        //DoStuff
        Debug.Log("I Just detected Something");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField]
    private Movement _movement;

    public Life EnemyLife;
    
    // Start is called before the first frame update
    void Start()
    {
        EnemyLife.ResetHP();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.SimpleMovement(Vector3.left);
    }
}

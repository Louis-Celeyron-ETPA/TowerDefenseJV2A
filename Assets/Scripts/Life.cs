using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Life : MonoBehaviour
{

    [SerializeField] private int _maxHealthPoints;
    private int _healthPoints;

    public void ResetHP()
    {
        _healthPoints = _maxHealthPoints;
    }

    public bool IsDead()
    {
        return _healthPoints <= 0;
    }

    public void AddHP(int amount)
    {
        _healthPoints += amount;
    }
    
    public void DecreaseHp(int amount)
    {
        AddHP(-amount);
    }

}

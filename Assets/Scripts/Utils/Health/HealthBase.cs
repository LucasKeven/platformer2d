using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    [Header("")]
    public float startLife = 1;

    public bool destroyOnKill = false;

    private float _currentLife;
    private bool _isDead;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _isDead = false;
        _currentLife = startLife;
    }

    public void Damage(int damage)
    {
        
        if(_isDead) return;
        
        _currentLife -= damage;

        if (_currentLife <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        _isDead = true;

        if (destroyOnKill)
        {
            Destroy(gameObject);
        }
    }
}

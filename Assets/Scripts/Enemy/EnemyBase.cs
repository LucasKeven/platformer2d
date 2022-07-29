using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
   [Header("")]
   public int damage = 10;

   private void OnTriggerEnter2D(Collider2D collision)
   {
        Debug.Log(collision.transform.name);
        
        var health = collision.GetComponent<HealthBase>();

        if (health != null)
        {
            health.Damage(damage);
        }
   }
}

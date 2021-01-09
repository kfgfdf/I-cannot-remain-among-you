using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEableEntity : MonoBehaviour
{
   public float HealthPoints;
   public void TakeDamage(float damage)
    {
        HealthPoints -= damage;
        if(HealthPoints <= 0)
        {
            HealthPoints = 0;
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}

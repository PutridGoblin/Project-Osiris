using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // For testing purposes
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);

            if(currentHealth <= 0)
            {
                Die();
            }
        }
    }

    // For testing purposes
    void TakeDamage(int damage)
    {
        

        healthBar.SetHealth(currentHealth, damage);

        currentHealth -= damage;
    }

    void Die()
    {
        
    }
}

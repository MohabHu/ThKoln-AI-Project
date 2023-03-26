using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    public int health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectiles"))
        {
            // Reduce the enemy's health
            health--;

            // Destroy the bullet
            Destroy(collision.gameObject);

            // Check if the enemy's health has reached zero
            if (health <= 0)
            {
                // Destroy the enemy
                Destroy(gameObject);
            }
        }
    }
}

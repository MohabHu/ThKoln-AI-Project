using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public int armor = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet") || collision.CompareTag("MeleeEnemy"))
        {
            // Check if the armor is greater than zero
            if (armor > 0)
            {
                // Reduce the armor
                armor--;
            }
            else
            {
                // Reduce the health if armor is zero
                health--;
            }

            // Destroy
            Destroy(collision.gameObject);

            // Check if the player's health has reached zero
            if (health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            print("Armor: " + armor);
            print("Health" + health);
        }
    }
}

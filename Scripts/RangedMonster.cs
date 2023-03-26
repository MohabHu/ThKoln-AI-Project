using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedMonster : MonoBehaviour
{
    public Transform player;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10.0f;
    public float fireRate = 1.0f;
    public float attackRange = 10.0f;

    private float nextFire = 0.0f;

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < attackRange)
        {
            // Calculate the direction to shoot the projectile
            Vector2 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Shoot the projectile at the player
            if (Time.time > nextFire)
            {
                Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
                GameObject projectile = Instantiate(projectilePrefab, transform.position, rotation);
                Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
                rb.velocity = rotation * Vector2.right * projectileSpeed;
                nextFire = Time.time + fireRate;
            }
        }
    }
}

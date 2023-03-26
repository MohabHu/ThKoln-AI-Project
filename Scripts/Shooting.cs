using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10.0f;
    public HandRotation hand;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Create a new projectile instance
            Vector2 direction = hand.handDirection;
            GameObject projectile = Instantiate(projectilePrefab, transform.position , transform.rotation);

            // Set the direction of the projectile based on the direction of the object

            
            projectile.GetComponent<Rigidbody2D>().velocity = direction.normalized * projectileSpeed;
        }
    }
}

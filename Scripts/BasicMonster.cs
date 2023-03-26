using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMonster : MonoBehaviour
{
    public Transform player;
    public float chaseSpeed = 5.0f;
    public float chaseRange = 10.0f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < chaseRange)
        {
            Vector2 direction = player.position - transform.position;
            rb.velocity = direction.normalized * chaseSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}

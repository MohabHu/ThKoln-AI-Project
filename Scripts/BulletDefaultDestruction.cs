using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDefaultDestruction : MonoBehaviour
{
    public float destroyDelay = 5.0f;

    private void Start()
    {
        // Destroy the object after the specified delay
        Destroy(gameObject, destroyDelay);
    }
}

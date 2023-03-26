using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float minX = -10.0f;
    public float maxX = 10.0f;
    public Transform target;
    public float trackingSpeed = 5.0f;

    private void LateUpdate()
    {
        // Get horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate new camera position
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0.0f, 0.0f);

        // Track target
        if (target != null)
        {
            newPosition.x = Mathf.Lerp(newPosition.x, target.position.x, trackingSpeed * Time.deltaTime);
        }

        // Clamp camera position within limits
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Set new camera position
        transform.position = newPosition;
    }
}

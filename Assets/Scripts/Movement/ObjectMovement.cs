using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float maxXPosition = 2f;
    public float minXPosition = -2f;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float newPosition = transform.position.x + horizontalInput;

        // Ограничиваем позицию объекта по оси X
        newPosition = Mathf.Clamp(newPosition, minXPosition, maxXPosition);

        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}

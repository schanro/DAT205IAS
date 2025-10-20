using UnityEngine;

public class RotateCounterClockwise : MonoBehaviour
{

    [Tooltip("Rotation speed in degrees per second.")]
    public float rotationSpeed = 90f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);        
    }
}

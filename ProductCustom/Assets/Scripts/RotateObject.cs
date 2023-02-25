using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f;

    private bool isRotating = false;
    private int rotationDirection = 1; // 1 for clockwise, -1 for counterclockwise

    public void StartRotatingForward()
    {
        // Start rotating in a forward direction (clockwise)
        isRotating = true;
        rotationDirection = 1;
    }

    public void StartRotatingBackward()
    {
        // Start rotating in a backward direction (counterclockwise)
        isRotating = true;
        rotationDirection = -1;
    }

    public void StopRotating()
    {
        // Stop rotating
        isRotating = false;
    }

    void Update()
    {
        // Check if we should rotate
        if (isRotating)
        {
            // Calculate the amount to rotate based on the time since the last frame
            float rotationAmount = rotationSpeed * rotationDirection * Time.deltaTime;

            // Rotate the object on the z-axis
            transform.Rotate(0f, 0f, rotationAmount);
        }
    }
}

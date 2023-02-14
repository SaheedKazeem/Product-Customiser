using UnityEngine;
using UnityEngine.EventSystems;

public class RotateObject : MonoBehaviour
{
    public GameObject button;
    public float rotationSpeed = 50f;

    private bool isButtonPressed = false;

    void Update()
    {
        if (button != null)
        {
            if (Input.GetMouseButtonDown(0) && button == EventSystem.current.currentSelectedGameObject)
            {
                isButtonPressed = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                isButtonPressed = false;
            }
        }

        if (isButtonPressed)
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }
}

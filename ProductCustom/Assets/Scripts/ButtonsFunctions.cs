using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonsFunctions : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public Button rotateButton;
    private bool isRotating = false;

    private void Start()
    {
        rotateButton.onClick.AddListener(StartRotatingCamera);
    }

    void StartRotatingCamera()
    {
        isRotating = true;
    }

    private void Update()
    {
        if (isRotating && Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed);
        }
        else
        {
            isRotating = false;
        }
    }
}


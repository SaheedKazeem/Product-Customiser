using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EyeVisibility : MonoBehaviour
{
    public GameObject targetObject, buttonTargetObject;
    public Button toggleButton;

    void Start()
    {
        if (targetObject == null)
        {
            Debug.LogError("Please assign a target GameObject in the inspector.");
            return;
        }

        // Set the initial button label based on the initial active state of the target object
        UpdateButtonLabel();

        // Add a click listener to the button
        toggleButton.onClick.AddListener(ToggleObject);
    }

    void UpdateButtonLabel()
    {
        // Update the button label to reflect the current active state of the target object
        if (targetObject.activeSelf)
        {
            toggleButton.GetComponentInChildren<TextMeshProUGUI>().text = "Off";
        }
        else
        {
            toggleButton.GetComponentInChildren<TextMeshProUGUI>().text = "On";
        }
    }

    void ToggleObject()
    {
        // Toggle the active state of the target object
        targetObject.SetActive(!targetObject.activeSelf);
        buttonTargetObject.SetActive(!buttonTargetObject.activeSelf);
        
        // Update the button label to reflect the new active state of the target object
        UpdateButtonLabel();
    }
}


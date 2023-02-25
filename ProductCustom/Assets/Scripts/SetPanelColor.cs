using UnityEngine;
using UnityEngine.UI;

public class SetPanelColor : MonoBehaviour
{
    public GameObject targetObject;
    public Image panelImage;

    void Update()
    {
        // Get the material of the target object
        Material material = targetObject.GetComponent<Renderer>().material;

        // Set the color of the panel to the color of the material
        panelImage.color = material.color;
    }
}

using UnityEngine;

public class ChangeMaterialColour : MonoBehaviour
{
    public Color[] colors;
    public int materialSlot = 0;

    private int currentColorIndex = 0;

    private void Start()
    {
        SetMaterialColor(currentColorIndex);
    }

    private void SetMaterialColor(int index)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
    if (meshRenderer != null && index >= 0 && index < colors.Length)
    {
        Material[] materials = meshRenderer.materials;
        materials[materialSlot].SetColor("_BaseColor", colors[index]);
        meshRenderer.materials = materials;
    }
    }

    public void NextColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        SetMaterialColor(currentColorIndex);
    }

    public void PrevColor()
    {
        currentColorIndex--;
        if (currentColorIndex < 0)
        {
            currentColorIndex = colors.Length - 1;
        }
        SetMaterialColor(currentColorIndex);
    }
}

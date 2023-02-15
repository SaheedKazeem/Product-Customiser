using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material[] materials;
    public int materialSlot = 0;
    private int currentIndex = 0;

    void Start()
    {
        SetMaterial(currentIndex);
    }

    public void NextMaterial()
    {
        currentIndex++;
        if (currentIndex >= materials.Length)
        {
            currentIndex = 0;
        }
        SetMaterial(currentIndex);
    }

    public void PreviousMaterial()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = materials.Length - 1;
        }
        SetMaterial(currentIndex);
    }

    private void SetMaterial(int index)
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
    if (meshRenderer != null && index >= 0 && index < materials.Length)
    {
        Material[] instanceMaterials = meshRenderer.materials;
        instanceMaterials[materialSlot] = Instantiate(materials[index]);
        meshRenderer.materials = instanceMaterials;
    }
    }
}

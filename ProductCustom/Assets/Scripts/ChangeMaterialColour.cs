using UnityEngine;

public class ChangeMaterialColour : MonoBehaviour
{
    public Material material;
    public Color[] colors = new Color[] { Color.red, Color.green, Color.blue };
    private int currentIndex = 0;

    void Start()
    {
        material.color = colors[currentIndex];
    }

    public void NextColor()
    {
        currentIndex++;
        if (currentIndex >= colors.Length)
        {
            currentIndex = 0;
        }
        material.color = colors[currentIndex];
    }

    public void PreviousColor()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = colors.Length - 1;
        }
        material.color = colors[currentIndex];
    }
}

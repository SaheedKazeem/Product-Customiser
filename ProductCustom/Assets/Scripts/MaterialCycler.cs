using UnityEngine;
using UnityEngine.UI;

public class MaterialCycler : MonoBehaviour
{
    public Color[] colors;
    public Renderer targetRenderer;
    public int currentIndex = 0;
    public Button forwardButton;
    public Button backButton;

    void Start()
    {
        if (targetRenderer == null || colors.Length < 2)
        {
            Debug.LogError("Please assign a Renderer component and at least 2 colors in the inspector.");
            return;
        }

        // Set the initial color
        targetRenderer.material.color = colors[currentIndex];

        // Add click listeners to the buttons
        forwardButton.onClick.AddListener(NextColor);
        backButton.onClick.AddListener(PreviousColor);
    }

    void NextColor()
    {
        currentIndex = (currentIndex + 1) % colors.Length;
        targetRenderer.material.color = colors[currentIndex];
    }

    void PreviousColor()
    {
        currentIndex = (currentIndex + colors.Length - 1) % colors.Length;
        targetRenderer.material.color = colors[currentIndex];
    }
}
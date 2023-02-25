using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionCycler : MonoBehaviour
{
    public TMP_Text descriptionText;
    public Button backButton;
    public Button forwardButton;
    public string[] descriptions;
    private int currentIndex = 0;

    void Start()
    {
        // Display the first description in the array
        descriptionText.text = descriptions[currentIndex];

        // Add click listeners to the forward and back buttons
        backButton.onClick.AddListener(OnBackButton);
        forwardButton.onClick.AddListener(OnForwardButton);
    }

    void OnBackButton()
    {
        // Decrement the current index and wrap around if needed
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = descriptions.Length - 1;
        }

        // Display the new description
        descriptionText.text = descriptions[currentIndex];
    }

    void OnForwardButton()
    {
        // Increment the current index and wrap around if needed
        currentIndex++;
        if (currentIndex >= descriptions.Length)
        {
            currentIndex = 0;
        }

        // Display the new description
        descriptionText.text = descriptions[currentIndex];
    }
}

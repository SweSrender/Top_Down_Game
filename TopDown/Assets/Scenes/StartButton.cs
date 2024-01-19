using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;

    private void Start()
    {
        // Attach the Click event to the method
        startButton.onClick.AddListener(StartGame);
    }

    // Method to be called when the button is clicked
    private void StartGame()
    {
        // Load your main game scene or perform any other necessary actions
        SceneManager.LoadScene("SampleScene");
    }
}

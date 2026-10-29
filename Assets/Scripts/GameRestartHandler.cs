using UnityEngine;
using UnityEngine.SceneManagement; // Required for managing and loading scenes

public class GameRestartHandler : MonoBehaviour
{
    /// <summary>
    /// Restarts the currently active scene.
    /// Attach this method to your UI Button's OnClick event.
    /// </summary>
    public void RestartGame()
    {
        // Resets the time scale to normal speed in case the game was paused (e.g., on a Game Over screen)
        Time.timeScale = 1f;

        // Gets the index of the currently active scene and reloads it
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
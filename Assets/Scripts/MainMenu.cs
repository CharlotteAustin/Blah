using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Settings()
    {
        // Hide and show different elements in the canvas
        // rather than loading a new scene, will be quicker
    }

    public void Exit()
    {
        Application.Quit();
    }
}

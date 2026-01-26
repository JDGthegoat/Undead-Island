using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToTutorial : MonoBehaviour
{
    // Call this from a UI Button OnClick() or from code
    public void SwitchToTutorialScene()
    {
        // Synchronous load (simple). Make sure "Tutorial" is in Build Settings.
        SceneManager.LoadScene("Tutorial");
    }

    // Optional: async version (non-blocking)
    public void SwitchToTutorialSceneAsync()
    {
        SceneManager.LoadSceneAsync("Tutorial", LoadSceneMode.Single);
    }
}
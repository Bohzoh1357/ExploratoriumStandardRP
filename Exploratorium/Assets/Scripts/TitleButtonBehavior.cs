using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonBehavior : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Closing Game. Thanks for playing!");
        Application.Quit();
    }

    public void StartGame()
    {
        Debug.Log("Opening StartGame scene (index 1)");
        SceneManager.LoadScene(1);
    }

    public void ViewCredits()
    {
        Debug.Log("Opening Credits scene (index 2)");
        SceneManager.LoadScene(2);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButtonBehavior : MonoBehaviour
{
    private GameObject errorMessage;

    private void Start()
    {
        if (transform.parent != null && transform.parent.childCount > 7)
        {
            errorMessage = transform.parent.GetChild(7).gameObject;
            errorMessage.SetActive(false);
        }
    }
    public void ExitGame()
    {
        Debug.Log("Closing Game. Thanks for playing!");
        errorMessage.SetActive(true);        
        // Application.Quit();
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

    public void MainMenu()
    {
        Debug.Log("Opening Main Menu Screen (index 0)");
        SceneManager.LoadScene(0);
    }
}

using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuButtons : MonoBehaviour
{

    public bool isOptionsOpen;
    public GameObject optionsMenu;
    public GameObject exitGameButton;
    public FirstPersonController playerCharacter;

    private void Start()
    {
        isOptionsOpen = false;
        optionsMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isOptionsOpen = !isOptionsOpen;
            optionsMenu.SetActive(isOptionsOpen);
            playerCharacter.enabled = !isOptionsOpen;
        }
    }

    public void ReturnToMainMenu()
    {
        exitGameButton.GetComponent<Button>().enabled = false;
        exitGameButton.transform.GetChild(0).GetComponent<TMP_Text>().text = "Cannot Exit Game.";
    }

    public void CloseOptionsMenu()
    {
        isOptionsOpen = !isOptionsOpen;
        optionsMenu.SetActive(isOptionsOpen);
        playerCharacter.enabled = !isOptionsOpen;
    }
}

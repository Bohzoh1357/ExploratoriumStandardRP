using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ManageUI : MonoBehaviour
{
    public bool isMinimapFound;
    public bool isStaticMapFound;

    private bool isMinimapToggled;
    private bool isStaticMapToggled;
    private bool displayNewTooltip;
    private bool displayResultsScreen;

    public GameObject minimap;
    public GameObject staticMap;
    public GameObject tooltip;
    public GameObject results;
    public TMP_Text starShardCount;
    public GameManager gameManager;

    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMinimapFound = false;
        isStaticMapFound = false;

        isMinimapToggled = false;
        isStaticMapToggled = false;
        displayNewTooltip = false;
        displayResultsScreen = false;

        timer = 0.0f;

        minimap.SetActive(isMinimapToggled);
        staticMap.SetActive(isStaticMapToggled);
        tooltip.SetActive(false);
        results.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if (isMinimapFound)
            {
                isMinimapToggled = !isMinimapToggled;
            }
            if (isStaticMapFound)
            {
                isStaticMapToggled = !isStaticMapToggled;
            }
            minimap.SetActive(isMinimapToggled);
            staticMap.SetActive(isStaticMapToggled);
        }
        if (displayNewTooltip)
        {
            timer += Time.deltaTime;
            if (timer > 5.0f)
            {
                displayNewTooltip = false;
                tooltip.SetActive(false);
                timer = 0.0f;
            } else
            {
                tooltip.SetActive(true);
            }
        }
        if (displayResultsScreen)
        {
            results.SetActive(true);
        }

        starShardCount.text = "Star Shards: " + gameManager.starCount;
    }

    public void ResetUI()
    {
        isMinimapToggled=false;
        isStaticMapToggled=false;
        minimap.SetActive(isMinimapToggled);
        staticMap.SetActive(isStaticMapToggled);
        displayNewTooltip = true;
    }

    public void DisplayWinScreen()
    {
        isMinimapToggled = false;
        isStaticMapToggled = false;
        minimap.SetActive(false);
        staticMap.SetActive(false);
        results.SetActive(true);
    }
}

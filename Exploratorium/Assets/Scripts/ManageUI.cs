using Unity.VisualScripting;
using UnityEngine;

public class ManageUI : MonoBehaviour
{
    public bool isMinimapFound;
    public bool isStaticMapFound;

    private bool isMinimapToggled;
    private bool isStaticMapToggled;
    private bool displayNewTooltip;

    public GameObject minimap;
    public GameObject staticMap;
    public GameObject tooltip;

    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMinimapFound = false;
        isStaticMapFound = false;

        isMinimapToggled = false;
        isStaticMapToggled = false;
        displayNewTooltip = false;

        timer = 0.0f;

        minimap.SetActive(isMinimapToggled);
        staticMap.SetActive(isStaticMapToggled);
        tooltip.SetActive(false);
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
    }

    public void ResetUI()
    {
        isMinimapToggled=false;
        isStaticMapToggled=false;
        minimap.SetActive(isMinimapToggled);
        staticMap.SetActive(isStaticMapToggled);
        displayNewTooltip = true;
    }


}

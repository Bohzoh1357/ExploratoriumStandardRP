using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ManageUI ui;


    public void triggerFoundMinimap()
    {
        ui.isMinimapFound = true;
        ui.ResetUI();
    }

    public void triggerFoundStaticMap()
    {
        ui.isStaticMapFound = true;
        ui.ResetUI();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ManageUI ui;

    public int starCount;

    public float timer;
    public AK.Wwise.RTPC starCountRTPC;

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
        starCount = 0;
        timer = 0.0f;
        starCountRTPC.SetGlobalValue(starCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (starCount == 5)
        {
            ui.DisplayWinScreen();
            timer += Time.deltaTime;
            if (timer > 7.0f)
            {
                GetComponent<TitleButtonBehavior>().MainMenu();
            }
        }
    }

    public void starIncrement()
    {
        starCount++;
        starCountRTPC.SetGlobalValue(starCount);
    }
}

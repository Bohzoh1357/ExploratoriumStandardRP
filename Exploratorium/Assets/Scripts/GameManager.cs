using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ManageUI ui;

    public int starCount;

    public float timer;
    public float endgameTimer;
    public AK.Wwise.RTPC starCountRTPC;
    public AK.Wwise.Event stopMusic;
    public AK.Wwise.Event endgameMusic;
    public GameObject lastStar;
    public bool timerEnable;
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
        endgameTimer = 0.0f;
        starCountRTPC.SetGlobalValue(starCount);
        timerEnable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerEnable == true)
        {
            endgameTimer += Time.deltaTime;
            if (endgameTimer > 2.0f)
            {
                endGame();
                timerEnable = false;
            }
        }
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

    public void delayEndGame()
    {
        timerEnable = true;
    }

    private void endGame()
    {
        lastStar = GameObject.FindWithTag("star");
        stopMusic.Post(this.gameObject);
        endgameMusic.Post(lastStar);
        Debug.Log("We're in the endgame now");
    }

}


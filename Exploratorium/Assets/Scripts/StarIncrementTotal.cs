using StarterAssets;
using UnityEngine;

public class StarIncrementTotal : MonoBehaviour
{
    public GameManager gameManager;
    public AK.Wwise.State starState;
    public AK.Wwise.Event collectionStinger;
    public AK.Wwise.Event stopRegionMusic;

    public GameObject uiPickupCanvas;

    public bool canPickup;
    public bool readyToDestroy;
    public bool endGame;

    private int timeToDestroy;
    private int measureCountdown;

    private void Start()
    {
        measureCountdown = 0;
        timeToDestroy = 1;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        uiPickupCanvas = GameObject.Find("Canvas UI").transform.GetChild(6).gameObject;
        canPickup = false;
        readyToDestroy = false;
        endGame = false;
    }

    private void Update()
    {
        if (canPickup && Input.GetKeyDown(KeyCode.E))
        {
            starState.SetValue();
            collectionStinger.Post(this.gameObject);
            gameManager.starIncrement();
            uiPickupCanvas.SetActive(false);
            canPickup = false;
            readyToDestroy = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // set canvas to active
            uiPickupCanvas.gameObject.SetActive(true);
            canPickup = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // set canvas to active
            uiPickupCanvas.gameObject.SetActive(false);
            canPickup = false;
        }
    }

    void callbackDestroy()
    {
       
        if(readyToDestroy)
        {
            if (gameManager.starCount == 4)
            {
                timeToDestroy = 4;
                stopRegionMusic.Post(this.gameObject);

            }
            if (measureCountdown == timeToDestroy)
            {
                Debug.Log("ready to destroy");
                readyToDestroy = false;

                if (timeToDestroy == 4)
                {
                    gameManager.delayEndGame();
                }
                GameObject.Destroy(gameObject);

            }
            else
            {
                measureCountdown++;
            }
        }
        
    }

}

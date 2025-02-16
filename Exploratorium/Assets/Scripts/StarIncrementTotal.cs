using StarterAssets;
using UnityEngine;

public class StarIncrementTotal : MonoBehaviour
{
    public GameManager gameManager;
    public AK.Wwise.State starState;
    public AK.Wwise.Event collectionStinger;

    public GameObject uiPickupCanvas;

    public bool canPickup;

    public float timeToDestroy;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        uiPickupCanvas = GameObject.Find("Canvas UI").transform.GetChild(6).gameObject;
        canPickup = false;
    }

    private void Update()
    {
        if (canPickup && Input.GetKeyDown(KeyCode.E))
        {
            gameManager.starIncrement();
            starState.SetValue();
            collectionStinger.Post(this.gameObject, (uint)AkCallbackType.AK_MusicSyncUserCue, callbackDestroy); // callback stuff here, make a function for it
            uiPickupCanvas.SetActive(false);
            canPickup = false;
            GameObject.Destroy(gameObject, timeToDestroy);
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

    void callbackDestroy(object in_cookie, AkCallbackType in_type, object in_info)
    {
        //GameObject.Destroy(gameObject);
        Debug.Log("Entry Cue");
    }

}

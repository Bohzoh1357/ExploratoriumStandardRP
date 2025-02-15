using UnityEngine;

public class StarIncrementTotal : MonoBehaviour
{
    public GameManager gameManager;
    public AK.Wwise.State starState;
    public AK.Wwise.Event collectionStinger;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.starIncrement();
            starState.SetValue();
            collectionStinger.Post(this.gameObject);
            GameObject.Destroy(gameObject);
        }
    }
}

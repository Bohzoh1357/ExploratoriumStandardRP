using UnityEngine;

public class StarIncrementTotal : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.starCount++;
            GameObject.Destroy(gameObject);
        }
    }
}

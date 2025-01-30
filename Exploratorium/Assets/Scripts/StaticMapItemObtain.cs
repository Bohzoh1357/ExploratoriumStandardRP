using UnityEngine;

public class StaticMapItemObtain : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.triggerFoundStaticMap();
            GameObject.Destroy(gameObject);
        }
    }
}

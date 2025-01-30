using UnityEngine;

public class MinimapItemObttain : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.triggerFoundMinimap();
            GameObject.Destroy(gameObject);
        }
    }
}

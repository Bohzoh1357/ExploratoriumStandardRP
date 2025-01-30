using UnityEngine;

public class StarPassiveMovement : MonoBehaviour
{
    private Transform myTransform;
    private float timer = 0f;

    private void Start()
    {
        myTransform = transform;
    }
    // Update is called once per frame

    void Update()
    {
        timer += Time.deltaTime;

        // oscillation
        Vector3 position = myTransform.position;
        position.y = position.y + (Mathf.Sin(timer) / 3f) * Time.deltaTime;
        myTransform.position = position;
    }
}

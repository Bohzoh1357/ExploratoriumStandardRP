using UnityEngine;

public class SecretGameEnder : MonoBehaviour
{
    public int leftStar = 0;
    public int rightStar = 0;

    public float timer = 0.0f;

    public GameObject endScreen;
    public GameObject menuCanvas;
    private void Start()
    {
        leftStar = 0;
        rightStar = 0;
        timer = 0.0f;
    }

    private void Update()
    {
        if (leftStar == 2 && rightStar == 5)
        {
            timer += Time.deltaTime;
            endScreen.SetActive(true);
            menuCanvas.SetActive(false);
        }

        if (timer > 6.0f)
        {
            Application.Quit();
        }
    }
}

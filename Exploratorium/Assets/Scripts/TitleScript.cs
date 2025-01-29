using UnityEngine;
using TMPro;

public class TitleScript : MonoBehaviour
{
    private TMP_Text titleText;

    private float timer = 0.0f;

    private float FPS = 60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        titleText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // increment title screen size
        if (titleText.characterSpacing < 25f && timer > 1f/FPS)
        {
            titleText.characterSpacing = titleText.characterSpacing + 1.0f - (0.039f * titleText.characterSpacing);
            timer = 0.0f;
        }
    }
}

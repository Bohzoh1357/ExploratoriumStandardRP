using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateSliderText : MonoBehaviour
{
    public TMP_Text text;

    public Slider slider;
    public AK.Wwise.RTPC volumeRTPC;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent<Slider>();
        text.text += slider.value.ToString("#.00");
        volumeRTPC.SetGlobalValue(slider.value);
    }

    public void UpdateText()
    {
        text.text = text.text.Split(" ")[0] + " " + text.text.Split(" ")[1] + " " + slider.value.ToString("#.00");
        volumeRTPC.SetGlobalValue(slider.value);
    }
}

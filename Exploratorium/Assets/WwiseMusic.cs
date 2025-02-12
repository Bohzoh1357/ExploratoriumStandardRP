using UnityEngine;

public class WwiseMusic : MonoBehaviour
{
    public AK.Wwise.State nightMusic;
    public void NightMusic()
    {
        if (nightMusic != null)
            nightMusic.SetValue();
        Debug.Log("state change");
    }
}

using UnityEngine;

public class WwiseMusic : MonoBehaviour
{
    public AK.Wwise.Event nightMusic;
    public void NightMusic()
    {
        if (nightMusic != null)
            nightMusic.Post(this.gameObject);
        Debug.Log("called night music");
    }
}

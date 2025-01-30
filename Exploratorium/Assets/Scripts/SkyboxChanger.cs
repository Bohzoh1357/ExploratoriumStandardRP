using Sydewa;
using UnityEngine;

public class SkyboxChanger : MonoBehaviour
{
    public Material skyboxDay;
    public Material skyboxNight;
    public LightingManager lightingManager;
    
    private bool toDayTransition = false;
    private bool toNightTransition = false;
    private bool changeSkybox = false;

    public void DayToNight()
    {
        //toNightTransition = true;
        //changeSkybox = true;
        RenderSettings.skybox = skyboxNight;
    }

    public void NightToDay()
    {
        //toDayTransition = true;
        RenderSettings.skybox = skyboxDay;
    }

    //public void Update()
    //{
    //    if (toDayTransition)
    //    {
    //        Color skyboxUpdatedColor = skyboxNight.color;

    //        if (skyboxUpdatedColor.a > 0.01f)
    //        {
    //            skyboxUpdatedColor.a -= Time.deltaTime / 3f;
    //            skyboxNight.color = skyboxUpdatedColor;
    //            RenderSettings.skybox = skyboxNight;
    //        } 
    //        else
    //        {
    //            toDayTransition = false;
    //            RenderSettings.skybox = skyboxDay;
    //        }
    //    } else if (toNightTransition)
    //    {
    //        if (changeSkybox)
    //        {
    //            Color skyboxColor = skyboxNight.color;
    //            skyboxColor.a = 0f;
    //            skyboxNight.color = skyboxColor;
    //            RenderSettings.skybox = skyboxNight;
    //            changeSkybox = false;
    //        }

    //        Color skyboxUpdatedColor = skyboxNight.color;
    //        if (skyboxUpdatedColor.a < 0.99f)
    //        {
    //            skyboxUpdatedColor.a += Time.deltaTime / 3f;
    //            skyboxNight.color = skyboxUpdatedColor;
    //            RenderSettings.skybox = skyboxNight;
    //        }
    //        else
    //        {
    //            toNightTransition = false;
    //            skyboxUpdatedColor.a = 1f;
    //            skyboxNight.color = skyboxUpdatedColor;
    //            RenderSettings.skybox = skyboxNight;
    //        }
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuncyAudio_Glow : MonoBehaviour
{
    Transform player;
    Light suncyLight;


    IEnumerator LightGlow(Light light, float intensity, float duration)
    {
        float counter = 0;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            light.intensity = intensity;
            yield return null;
        }
    }

    IEnumerator WaterNearby()
    {
        yield return new WaitForSeconds(6f);
        float randomSeconds = Random.Range(80f, 180f);
        AudioManager.instance.Play("WaterNearby");
        yield return new WaitForSeconds(randomSeconds);
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        suncyLight = GetComponent<Light>();

        AudioManager.instance.Play("SuncyHelpMeIntro");
        StartCoroutine(LightGlow(suncyLight, 4, 2));

        suncyLight.intensity = 1;
    }


    // Update is called once per frame
    void Update()
    {
        //  when taking damage
        // AudioManager.instance.Play("SuncyWatchOut");
        //StartCoroutine(LightGlow(suncyLight, 4, 2));
        //suncyLight.intensity = 1;

        //  when game win acheived
        // AudioManager.instance.Play("SuncyFarewell");
        //StartCoroutine(LightGlow(suncyLight, 4, 2));

        StartCoroutine(WaterNearby());
    }
}

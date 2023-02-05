using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogeAudio : MonoBehaviour
{
    public string AudioName;

    IEnumerator IdleFrog()
    {
        //yield return new WaitForSeconds(6f);
        float randomSeconds = Random.Range(2f, 10f);
        AudioManager.instance.Play(AudioName);
        yield return new WaitForSeconds(randomSeconds);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            StartCoroutine(IdleFrog());
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

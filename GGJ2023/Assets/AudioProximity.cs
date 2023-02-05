using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioProximity : MonoBehaviour
{
    public string AudioName;
    //public GameObject 

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            AudioManager.instance.Play(AudioName);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            //collision.gameObject.transform.SetParent(null);
        }
    }

}

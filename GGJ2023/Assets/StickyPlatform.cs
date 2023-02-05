using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PlayerSkeleton")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

}

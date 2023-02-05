using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{

    public bool BucketsCollected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (BucketsCollected)
        {
            if (transform.localScale.y < 1)
            {
                var temp = transform.localScale;
                temp.y += 0.001f;
                temp.x += 0.001f;
                temp.z += 0.001f;
                transform.localScale = temp;
            }
        }    
    }


    
}

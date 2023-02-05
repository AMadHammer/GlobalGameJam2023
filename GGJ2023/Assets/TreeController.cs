using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{

    public bool AllBucketsCollected = false;
    public int BucketsToCollect;
    public PlayerInventory playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        //playerInventory = playerInventory.GetComponent<PlayerInventory>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        if(playerInventory.NumberOfBuckets >= BucketsToCollect)
        {
            AllBucketsCollected = true;
        }

        if (AllBucketsCollected)
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

    //when you are a distance from the tree
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();

            if (playerInventory.NumberOfBuckets == BucketsToCollect)
                AllBucketsCollected = true;
        }
    }


}

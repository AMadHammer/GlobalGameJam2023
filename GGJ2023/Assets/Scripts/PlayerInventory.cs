    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public int NumberOfDiamond { get; private set;}
    public int NumberOfBuckets { get; private set; }

    public UnityEvent<PlayerInventory> OnDiamondCollected;
    public UnityEvent<PlayerInventory> OnBucketCollected;

    public void DiamondCollected() {

        NumberOfDiamond++;
        OnDiamondCollected.Invoke(this);
    }
    public void BucketCollected()
    {

        NumberOfBuckets++;
        OnBucketCollected.Invoke(this);
    }

}

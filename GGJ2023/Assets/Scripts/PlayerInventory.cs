using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public int NumberOfDiamond { get; private set;}

    public UnityEvent<PlayerInventory> OnDiamondCollected;

    public void DiamondCollected() {

        NumberOfDiamond++;
        OnDiamondCollected.Invoke(this);
    }
}

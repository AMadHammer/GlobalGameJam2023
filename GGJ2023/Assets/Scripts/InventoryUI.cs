using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{

    private TextMeshProUGUI diamondText;
    private TextMeshProUGUI waterBucketText;

    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        waterBucketText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBucketText(PlayerInventory playerInventory)
    {

        waterBucketText.text = playerInventory.NumberOfBuckets.ToString();

    }
    public void UpdateDiamondText(PlayerInventory playerInventory){

        diamondText.text = playerInventory.NumberOfDiamond.ToString();
    
   }
   
}

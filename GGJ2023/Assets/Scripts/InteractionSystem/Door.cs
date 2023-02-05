using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{

 [SerializeField] private string _prompt;

    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {

        var inventory = interactor.GetComponent<InventoryBasic>();

        if (inventory == null) return false;

        if(inventory.HasKey){
            Debug.Log("Opening Door!");
            return true;
        }

        Debug.Log("YYou Need a Key!");
        return false;
    }
}

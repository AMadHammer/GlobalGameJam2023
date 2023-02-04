using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public int HP = 100;
    public Animator animator;


    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0){
            AudioManager.instance.Play("DragonDeath");
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else{
            AudioManager.instance.Play("DragonDamage");
           animator.SetTrigger("damage");
        }
    }
}

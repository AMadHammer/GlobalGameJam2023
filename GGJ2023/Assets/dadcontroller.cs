using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dadcontroller : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "PlayerSkeleton")
        {
            SceneManager.LoadScene("endingVideo");
        }
    }
}

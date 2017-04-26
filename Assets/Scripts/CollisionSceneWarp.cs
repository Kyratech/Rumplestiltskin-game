using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneWarp : SceneWarp
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Kek");
        if (other.CompareTag("Player") && other.GetComponent<PlayerMovement>().warpCooldown <= 0)
        {
            Debug.Log("Lol");
            controller.warpID = warpID;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

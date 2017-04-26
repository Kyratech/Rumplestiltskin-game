using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionSceneWarp : SceneWarp
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetComponent<PlayerMovement>().warpCooldown <= 0)
        {
            controller.warpID = warpID;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

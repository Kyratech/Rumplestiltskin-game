using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWarp : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.GetComponent<PlayerMovement>().warpCooldown <= 0)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

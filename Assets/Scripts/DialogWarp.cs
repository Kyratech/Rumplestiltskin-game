using UnityEngine;
using System.Collections;

/*
 * Warp the player, then bring up a dialog
 */
public class DialogWarp : Warp
{
    [SerializeField]
    private GameObject dialog;

    //Keeps track of time since dialog appeared, so player can't dismiss it by accident
    protected float pauseTimer;

    private bool active;
    private PlayerMovement player;

    void Start()
    {
        pauseTimer = 0.0f;
        active = false;
    }

    void Update()
    {
        //Decrement the pause timer
        if (pauseTimer > 0)
        {
            pauseTimer -= Time.deltaTime;
        }
        else if(active == true && Input.GetButtonDown("Inspect"))
        {
            player.setInteracting(false);
            dialog.SetActive(false);
            active = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player") && other.GetComponent<PlayerMovement>().warpCooldown <= 0)
        {
            player = other.GetComponent<PlayerMovement>();
            player.warpCooldown = cooldownTime;
            other.transform.position = warpTarget.position;
            Camera.main.transform.position = warpTarget.position;
        }

        player.setInteracting(true);
        dialog.SetActive(true);
        active = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectTile : MonoBehaviour {

    [SerializeField]
    protected GameObject dialogBox;

    //Keeps track of time since dialog appeared, so player can't dismiss it by accident
    protected float pauseTimer;

    void Start()
    {
        pauseTimer = 0.0f;
    }

	void Update ()
    {
        //Decrement the pause timer
		if(pauseTimer > 0)
        {
            pauseTimer -= Time.deltaTime;
        }
	}

    public virtual bool toggleDialog()
    {
        if (pauseTimer <= 0)
        {
            //Toggle state, reset timer
            dialogBox.SetActive(!dialogBox.activeInHierarchy);
            pauseTimer = 0.5f;
        }
        return dialogBox.activeInHierarchy;
    }

}

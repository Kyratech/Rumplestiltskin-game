using UnityEngine;
using System;

public class DemonTabletInspect : InspectTile
{
    private bool firstInspect = false;

    public override bool toggleDialog()
    {
        if (pauseTimer <= 0)
        {
            //Toggle state, reset timer
            dialogBox.SetActive(!dialogBox.activeInHierarchy);
            pauseTimer = 0.5f;

            if(!firstInspect)
            {
                firstInspect = true;
                GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
                gameController.readDemonTablet = true;
            }
        }
        return dialogBox.activeInHierarchy;
    }

}


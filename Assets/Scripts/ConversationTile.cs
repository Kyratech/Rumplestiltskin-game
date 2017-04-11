using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Triggers a chain of dialog boxes upon interaction
 * DialogBox variable becomes the first dialog in chain
 */
public abstract class ConversationTile : InspectTile
{
    //Determines whether the player can move or not
    private bool interacting;


    private void Start()
    {
        pauseTimer = 0.0f;
        interacting = false;

        initText();
    }

    public abstract void initText();

    public override bool toggleDialog()
    {
        if (pauseTimer <= 0)
        {
            //If not activated, activate and show the first dialog
            if(!interacting)
            {
                interacting = true;

                dialogBox.SetActive(true);
                dialogStart();
            }
            //OTherwise, the dialog should continue
            else
            {
                dialogBox.GetComponent<DialogItemController>().showNext(this);
            }

            //Avoid accidental skips
            pauseTimer = 0.5f;
        }
        return interacting;
    }

    /*
     * Optionally do something at the start of a dialog
     * Eg: change sprite
     */
    public abstract void dialogStart();

    /*
     * Optionally do something after a dialog has finished
     */
    public abstract void dialogFinish();

    /*
     * Set the lines spoken by this 'character'
     */
    public void setDialog(GameObject newDialog)
    {
        dialogBox = newDialog;
    }

    /*
     * End a conversation from outside this class
     */
     public void endInteraction()
    {
        interacting = false;
        dialogFinish();
    }
}

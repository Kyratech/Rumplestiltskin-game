using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ConversationTile : InspectTile {

    //List of conversation lines that will appear
    private List<string> lines;
    //Count the number of lines read
    private int lineCounter;

    private Text textObj;

    //Determines whether the player can move or not
    protected bool interacting;
    //Determines whether the dialog can be triggered
    private bool triggerable;

    public bool accessTriggerable
    {
        get
        {
            return triggerable;
        }
        set
        {
            triggerable = value;
        }
    }


    private void Start()
    {
        pauseTimer = 0.0f;
        lineCounter = 0;
        interacting = false;
        triggerable = true;

        textObj = dialogBox.transform.GetChild(0).gameObject.GetComponent<Text>();

        initText();
    }

    public abstract void initText();

    public override bool toggleDialog()
    {
        if (pauseTimer <= 0 && triggerable)
        {
            //If not activated, activate and set the first text
            if(!dialogBox.activeInHierarchy)
            {
                interacting = true;
                dialogBox.SetActive(true);
                textObj.text = lines[lineCounter++];
                dialogStartInit();
            }
            //Else activate the next text until the object no longer has any
            else if(lineCounter < lines.Count)
            {
                textObj.text = lines[lineCounter++];
            }
            //OTherwise, the dialog should be end
            else
            {
                dialogBox.SetActive(false);
                lineCounter = 0;
                dialogFinishInit();
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
    public abstract void dialogStartInit();

    /*
     * Optionally do something after a dialog has finished
     */
    public abstract void dialogFinishInit();

    /*
     * Set the lines spoken by this 'character'
     * Useful for changing dialog after eg first talk
     */
    public void setLines(List<string> newLines)
    {
        lines = newLines;
        lineCounter = 0;
    }
}

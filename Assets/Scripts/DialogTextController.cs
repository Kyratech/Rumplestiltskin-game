using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public abstract class DialogTextController : DialogItemController
{
    //List of conversation lines that will appear
    private List<string> lines;
    //Count the number of lines read
    private int lineCounter;

    [SerializeField]
    private Text textObj;

    /*
     * Set the lines spoken by this 'character'
     * Useful for changing dialog after eg first talk
     */
    public void setLines(List<string> newLines)
    {
        lines = newLines;
        textObj.text = lines[lineCounter++];
        
    }

    /*
     * Show the next line of dialog
     * or advance to the next item in the chain
     */
    public override void showNext(ConversationTile conversation)
    {
        if(lineCounter < lines.Count)
        {
            //Advance to next line in this dialog
            textObj.text = lines[lineCounter++];
        }
        else
        {
            //Reset to start of dialog
            lineCounter = 0;
            textObj.text = lines[lineCounter++];

            //Advance to next dialog if it exists
            if (nextDialog != null)
            {
                nextDialog.SetActive(true);
                nextDialog.GetComponent<DialogItemController>().extraSetup();
                conversation.setDialog(nextDialog);

                this.gameObject.SetActive(false);
            }
            else
            {
                conversation.endInteraction();
                this.gameObject.SetActive(false);
            }
        }
    }
}

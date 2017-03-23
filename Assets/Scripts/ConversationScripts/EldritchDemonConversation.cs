using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EldritchDemonConversation : ConversationTile {
    [SerializeField]
    private Sprite eldritchIdle;
    [SerializeField]
    private Sprite eldritchTalk;
    [SerializeField]
    private GameObject eldritchDemon;
    [SerializeField]
    private GameObject eldritchDialogOptionGameObject;

    bool firstInteract;

    public override void initText()
    {
        List<string> lines = new List<string>();
        lines.Add("This is unexpected.");
        lines.Add("Mortal.");
        lines.Add("What are you doing here.");

        this.setLines(lines);

        firstInteract = true;
    }

    public override void dialogStartInit()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchTalk;
    }

    public override void dialogFinishInit()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchIdle;
        
        //First time round, open the dialog choice box
        if(firstInteract)
        {
            eldritchDialogOptionGameObject.SetActive(true);
            firstInteract = false;
            //Disable the interaction tile until the choice has been made
            accessTriggerable = false;
        }
        else
        {
            List<string> lines = new List<string>();
            lines.Add("Additional advice:");
            lines.Add("Do not get involved in the affairs of demons.");

            this.setLines(lines);

            //Free the player from the converstaion
            interacting = false;
        }
        
        
    }
}

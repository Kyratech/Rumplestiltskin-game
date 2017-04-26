using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonDialogOptionController : DialogOptionController
{
    [SerializeField]
    private GameObject nameDialog;
    [SerializeField]
    private GameObject worldDialog;
    [SerializeField]
    private GameObject tributeDialog;

    public override void extraSetup()
    {
        //Nothing
    }

    /*
    * Set the demon's lines based on player response
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        switch (option)
        {
            //"Come to find demon name"
            case 0:
                nextDialog = nameDialog;
                break;
            //"Pay tribute"
            case 1:
                nextDialog = tributeDialog;
                break;
            //"Learn about the world"
            case 2:
                nextDialog = worldDialog;
                break;
        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

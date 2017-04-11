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
            //"Learn about the world"
            case 1:
                nextDialog = worldDialog;
                break;
            //"Pay tribute"
            case 2:
                nextDialog = tributeDialog;
                break;
        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

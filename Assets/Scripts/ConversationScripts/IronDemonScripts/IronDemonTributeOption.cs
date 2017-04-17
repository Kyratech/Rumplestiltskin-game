using UnityEngine;
using System.Collections;

public class IronDemonTributeOption : DialogOptionController
{
    [SerializeField]
    private GameObject ironDialog;
    [SerializeField]
    private GameObject otherDialog;

    /*
    * Set the demon's lines based on player response
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        switch (option)
        {
            case 0:
                nextDialog = ironDialog;
                break;
            case 1:
                nextDialog = otherDialog;
                break;
            case 2:
                nextDialog = otherDialog;
                break;

        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

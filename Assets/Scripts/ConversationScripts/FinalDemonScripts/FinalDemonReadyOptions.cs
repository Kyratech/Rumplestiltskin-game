using UnityEngine;
using System.Collections;

public class FinalDemonReadyOptions : DialogOptionController
{
    [SerializeField]
    private GameObject readyDialog;
    [SerializeField]
    private GameObject notReadyDialog;

    public override void extraSetup()
    {
        //Nothing
    }

    /*
    * Advance to final confrontation if ready
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        switch (option)
        {
            case 0:
                nextDialog = readyDialog;
                break;
            case 1:
                nextDialog = notReadyDialog;
                break;
        }

        nextDialog.SetActive(true);
        nextDialog.GetComponent<DialogItemController>().extraSetup();
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

using UnityEngine;
using System.Collections;

public class MerchantOption : DialogOptionController
{
    [SerializeField]
    private GameObject takenDialog;
    [SerializeField]
    private GameObject leftDialog;

    public override void extraSetup()
    {
        //Nothing
    }

    /*
    * Add the book to the player inventory if it was taken
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        switch (option)
        {
            //"Take book"
            case 0:
                nextDialog = takenDialog;
                break;
            //"Leave book"
            case 1:
                nextDialog = leftDialog;
                break;
        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

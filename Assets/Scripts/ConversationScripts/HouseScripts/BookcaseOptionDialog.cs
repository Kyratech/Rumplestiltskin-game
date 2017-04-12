using UnityEngine;
using System.Collections;

public class BookcaseOptionDialog : DialogOptionController
{
    [SerializeField]
    private GameObject takenDialog;
    [SerializeField]
    private GameObject leftDialog;

    /*
    * Add the book to the player inventory if it were taken
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

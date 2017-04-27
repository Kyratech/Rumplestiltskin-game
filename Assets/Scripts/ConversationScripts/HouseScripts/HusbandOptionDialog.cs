using UnityEngine;
using System.Collections;

public class HusbandOptionDialog : DialogOptionController
{
    [SerializeField]
    private GameObject loveDialog;
    [SerializeField]
    private GameObject jokeDialog;

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
                nextDialog = loveDialog;
                break;
            //"Leave book"
            case 1:
                nextDialog = jokeDialog;
                break;
        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

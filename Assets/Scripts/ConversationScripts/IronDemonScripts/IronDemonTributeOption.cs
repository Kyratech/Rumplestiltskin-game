using UnityEngine;
using System.Collections;

public class IronDemonTributeOption : DialogOptionController
{
    [SerializeField]
    private GameObject ironDialog;
    [SerializeField]
    private GameObject otherDialog;

    public override void extraSetup()
    {
        //This is slow as heck! Only in use because this is a game jam sort of scenario.
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        
    }

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

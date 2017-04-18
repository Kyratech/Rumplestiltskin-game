using UnityEngine;
using System.Collections;

public class CopperDemonTributeOptions : DialogOptionController
{
    [SerializeField]
    private GameObject ironDialog;
    [SerializeField]
    private GameObject mercuryDialog;
    [SerializeField]
    private GameObject copperDialog;
    [SerializeField]
    private GameObject defaultDialog;

    [SerializeField]
    private GameObject ironOption;
    [SerializeField]
    private GameObject mercuryOption;
    [SerializeField]
    private GameObject copperOption;
    [SerializeField]
    private GameObject defaultOption;

    public override void extraSetup()
    {
        //This is slow as heck! Only in use because this is a game jam sort of scenario.
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        if (gameController.hasIron || gameController.hasMercury || gameController.hasCopper)
        {
            ironOption.SetActive(gameController.hasIron);
            mercuryOption.SetActive(gameController.hasMercury);
            copperOption.SetActive(gameController.hasCopper);
        }
        else
        {
            defaultOption.SetActive(true);
        }
        UpdateOptions();
    }

    /*
    * Set the demon's lines based on player response
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        bool angered = false;

        switch (option)
        {
            case 0:
                nextDialog = ironDialog;
                angered = true;
                break;
            case 1:
                nextDialog = copperDialog;
                break;
            case 2:
                nextDialog = mercuryDialog;
                angered = true;
                break;
            case 3:
                nextDialog = defaultOption;
                angered = true;
                break;
        }

        /* Downcasting conversation to specific type
         * Assuming this script is only used where it is required,
         * This should always work.
         */
        CopperDemonConversation con = (conversation as CopperDemonConversation);
        if (con != null)
        {
            con.setAngered(angered);
        }

        nextDialog.SetActive(true);
        nextDialog.GetComponent<DialogItemController>().extraSetup();
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

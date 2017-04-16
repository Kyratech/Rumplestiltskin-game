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
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

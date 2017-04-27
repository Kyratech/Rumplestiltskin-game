using UnityEngine;
using System.Collections;

public class FinalChoiceOptions : DialogOptionController
{
    //Outcomes
    [SerializeField]
    private GameObject correctCertainDialog;
    [SerializeField]
    private GameObject correctGuessDialog;
    [SerializeField]
    private GameObject incorrectDialog;

    //Options
    [SerializeField]
    private GameObject beelzebubOption;
    [SerializeField]
    private GameObject belphegorOption;
    [SerializeField]
    private GameObject mammonOption;
    [SerializeField]
    private GameObject sathanusOption;
    [SerializeField]
    private GameObject goldOption;
    [SerializeField]
    private GameObject silverOption;
    [SerializeField]
    private GameObject quicksilverOption;
    [SerializeField]
    private GameObject copperOption;
    [SerializeField]
    private GameObject ironOption;
    [SerializeField]
    private GameObject tinOption;
    [SerializeField]
    private GameObject leadOption;

    bool certain = false;

    public override void extraSetup()
    {
        //This is slow as heck! Only in use because this is a game jam sort of scenario.
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        //If the player has book, then the metals are available
        if (gameController.hasBook)
        {
            goldOption.SetActive(true);
            silverOption.SetActive(true);
            quicksilverOption.SetActive(true);
            copperOption.SetActive(true);
            ironOption.SetActive(true);
            tinOption.SetActive(true);
            leadOption.SetActive(true);
        }
        //If the player has read the names, then replace the metals
        if (gameController.hasCopperName)
        {
            copperOption.SetActive(false);
            beelzebubOption.SetActive(true);
        }
        if (gameController.hasIronName)
        {
            ironOption.SetActive(false);
            belphegorOption.SetActive(true);
        }
        if (gameController.hasMercuryName)
        {
            quicksilverOption.SetActive(false);
            mammonOption.SetActive(true);
        }
        if (gameController.hasKeyName)
        {
            sathanusOption.SetActive(true);
        }
        //If the player has seen the tablet, remove iron and key option
        if (gameController.readDemonTablet && gameController.hasBook)
        {
            goldOption.SetActive(false);
            silverOption.SetActive(false);
            ironOption.SetActive(false);
            tinOption.SetActive(false);
            leadOption.SetActive(false);
            belphegorOption.SetActive(false);
            sathanusOption.SetActive(false);

            //If they have also eliminated the copper demon ambiguity
            if (gameController.metCopperDemon && (gameController.copperMetal == GameController.metals.copper || gameController.copperMetal == GameController.metals.mercury))
            {
                copperOption.SetActive(false);
                beelzebubOption.SetActive(false);

                certain = true;
            }
        }

        if (gameController.metCopperDemon && gameController.copperMetal == GameController.metals.copper)
        {
            copperOption.SetActive(false);
            beelzebubOption.SetActive(false);
        }

        if (gameController.metIronDemon && gameController.ironMetal == GameController.metals.iron)
        {
            ironOption.SetActive(false);
            belphegorOption.SetActive(false);
        }

        UpdateOptions();
    }

    /*
    * Advance to final confrontation if ready
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        switch (option)
        {
            case 0:
                nextDialog = incorrectDialog;
                break;
            case 1:
                if (certain)
                    nextDialog = correctCertainDialog;
                else
                    nextDialog = correctGuessDialog;
                break;
        }

        nextDialog.SetActive(true);
        nextDialog.GetComponent<DialogItemController>().extraSetup();
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

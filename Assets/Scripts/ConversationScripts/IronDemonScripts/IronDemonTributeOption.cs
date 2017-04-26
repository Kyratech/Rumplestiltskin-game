using UnityEngine;
using System.Collections;

public class IronDemonTributeOption : DialogOptionController
{
    [SerializeField]
    private GameObject ironDialog;
    [SerializeField]
    private GameObject otherDialog;
    [SerializeField]
    private GameObject nothingDialog;

    [SerializeField]
    private GameObject ironOption;
    [SerializeField]
    private GameObject copperOption;
    [SerializeField]
    private GameObject mercuryOption;
    [SerializeField]
    private GameObject nothingOption;

    public override void extraSetup()
    {
        //This is slow as heck! Only in use because this is a game jam sort of scenario.
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        if (gameController.hasIron || gameController.hasMercury || gameController.hasCopper)
        {
            ironOption.SetActive(gameController.hasIron);
            mercuryOption.SetActive(gameController.hasMercury);
            copperOption.SetActive(gameController.hasCopper);
            nothingOption.SetActive(false);
        }
        else
        {
            ironOption.SetActive(false);
            mercuryOption.SetActive(false);
            copperOption.SetActive(false);
            nothingOption.SetActive(true);
        }
        UpdateOptions();
    }

    /*
    * Set the demon's lines based on player response
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        gameController.metIronDemon = true;

        switch (option)
        {
            case 0:
                gameController.hasIron = false;
                nextDialog = ironDialog;
                gameController.ironMetal = GameController.metals.iron;
                break;
            case 1:
                nextDialog = otherDialog;
                gameController.ironMetal = GameController.metals.copper;
                break;
            case 2:
                nextDialog = otherDialog;
                gameController.ironMetal = GameController.metals.mercury;
                break;
            case 3:
                nextDialog = nothingDialog;
                break;
        }

        nextDialog.SetActive(true);
        nextDialog.GetComponent<DialogItemController>().extraSetup();
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

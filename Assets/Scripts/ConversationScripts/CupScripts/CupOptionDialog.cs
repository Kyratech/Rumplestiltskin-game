using UnityEngine;
using System.Collections;

public class CupOptionDialog : DialogOptionController
{
    [SerializeField]
    private GameObject takenDialog;
    [SerializeField]
    private GameObject leftDialog;

	enum Contents {Copper, Iron, Mercury, Key};
	[SerializeField]
	Contents contents;

    public override void extraSetup()
    {
        //Nothing
    }

    /*
    * Add the book to the player inventory if it was taken
    */
    public override void selectOption(int option, ConversationTile conversation)
    {
		GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        switch (option)
        {
            //"Take"
            case 0:
                nextDialog = takenDialog;
				switch(contents) {
					case Contents.Copper:
					gameController.hasCopper = true;
					gameController.hasCopperName = true;
        			break;
				case Contents.Iron:
				gameController.hasIron = true;
					gameController.hasIronName = true;
        			break;
				case Contents.Mercury:
				gameController.hasMercury = true;
					gameController.hasMercuryName = true;
        			break;
				case Contents.Key:
					gameController.hasKey = true;
					gameController.hasKeyName = true;
					break;
				default:
					break;
				}
                break;
            //"Leave"
            case 1:
			nextDialog = leftDialog;
			switch(contents) {
					case Contents.Copper:
					gameController.hasCopperName = true;
        			break;
				case Contents.Iron:
					gameController.hasIronName = true;
        			break;
				case Contents.Mercury:
					gameController.hasMercuryName = true;
        			break;
				case Contents.Key:
					gameController.hasKeyName = true;
					break;
				default:
					break;
				}
                break;
        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

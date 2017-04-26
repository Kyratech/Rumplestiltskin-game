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
        switch (option)
        {
            //"Take"
            case 0:
                nextDialog = takenDialog;
                GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
				switch(contents) {
					case Contents.Copper:
					gameController.hasCopper = true;
        			break;
				case Contents.Iron:
					gameController.hasIron = true;
        			break;
				case Contents.Mercury:
					gameController.hasMercury = true;
        			break;
				case Contents.Key:
					gameController.hasKey = true;
					break;
				default:
					break;
				}
                break;
            //"Leave"
            case 1:
                nextDialog = leftDialog;
                break;
        }

        nextDialog.SetActive(true);
        conversation.setDialog(nextDialog);

        this.gameObject.SetActive(false);
    }
}

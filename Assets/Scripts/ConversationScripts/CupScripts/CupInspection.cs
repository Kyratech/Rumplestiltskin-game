using UnityEngine;
using System.Collections;

/*
 * Don't need anything fancy for this one
 */
public class CupInspection : ConversationTile
{
	enum Contents {Copper, Iron, Mercury, Key};
	[SerializeField]
	Contents contents;
	[SerializeField]
	GameObject copperDialogOption;
	[SerializeField]
	GameObject ironDialogOption;
	[SerializeField]
	GameObject mercuryDialogOption;
	[SerializeField]
	GameObject keyDialogOption;

    public override void initText() { }

    public override void dialogStart() { }

    public override void dialogFinish()
    {
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();

        switch(contents) {
			case Contents.Copper:
				if (!gameController.hasCopper)
            		dialogBox = copperDialogOption;
        		break;
			case Contents.Iron:
				if (!gameController.hasIron)
            		dialogBox = ironDialogOption;
        		break;
			case Contents.Mercury:
				if (!gameController.hasMercury)
            		dialogBox = mercuryDialogOption;
        		break;
			case Contents.Key:
				if(!gameController.hasKey)
					dialogBox = keyDialogOption;
				break;
			default:
        			dialogBox = null;
        		break;
        }

    }
}

using UnityEngine;
using System.Collections;

/*
 * Don't need anything fancy for this one
 */
public class CupInspection : ConversationTile
{
	enum Metal {Copper, Iron, Mercury, Empty};
	[SerializeField]
	Metal contents;
	[SerializeField]
	GameObject copperDialogOption;
	GameObject ironDialogOption;
	GameObject mercuryDialogOption;
    GameObject emptyDialogOption;

    public override void initText() { }

    public override void dialogStart() { }

    public override void dialogFinish()
    {
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();


        switch(contents) {
        	case Metal.Copper:
				if (!gameController.hasCopper)
            		dialogBox = copperDialogOption;
        		break;
		case Metal.Iron:
				if (!gameController.hasIron)
            		dialogBox = ironDialogOption;
        		break;
		case Metal.Mercury:
				if (!gameController.hasMercury)
            		dialogBox = mercuryDialogOption;
        		break;
        	default:
        			dialogBox = emptyDialogOption;
        		break;
        }

    }
}

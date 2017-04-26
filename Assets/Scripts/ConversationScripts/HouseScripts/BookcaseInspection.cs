using UnityEngine;
using System.Collections;

/*
 * Don't need anything fancy for this one
 */
public class BookcaseInspection : ConversationTile
{
    [SerializeField]
    GameObject dialogOption;

    public override void initText() { }

    public override void dialogStart() { }

    public override void dialogFinish()
    {
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();

        if (!gameController.hasBook)
            dialogBox = dialogOption;
    }
}

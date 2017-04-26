using UnityEngine;
using System.Collections;

public class IronDemonConversation : ConversationTile
{
    [SerializeField]
    private Sprite ironIdle;
    [SerializeField]
    private Sprite ironTalk;
    [SerializeField]
    private GameObject ironDemon;
    [SerializeField]
    private GameObject secondInteractDialog;

    bool firstInteract;

    public override void initText()
    {
        firstInteract = true;
    }

    public override void dialogStart()
    {
        ironDemon.GetComponent<SpriteRenderer>().sprite = ironTalk;
    }

    public override void dialogFinish()
    {
        if (firstInteract)
        {
            firstInteract = false;
            setDialog(secondInteractDialog);
        }

        ironDemon.GetComponent<SpriteRenderer>().sprite = ironIdle;
    }
}

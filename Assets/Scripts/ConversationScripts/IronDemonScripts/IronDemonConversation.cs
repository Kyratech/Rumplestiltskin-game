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

    public override void initText()
    {
        
    }

    public override void dialogStart()
    {
        ironDemon.GetComponent<SpriteRenderer>().sprite = ironTalk;
    }

    public override void dialogFinish()
    {
        ironDemon.GetComponent<SpriteRenderer>().sprite = ironIdle;
    }
}

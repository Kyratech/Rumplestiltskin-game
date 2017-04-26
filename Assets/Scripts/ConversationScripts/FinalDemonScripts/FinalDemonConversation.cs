using UnityEngine;
using System.Collections;

public class FinalDemonConversation : ConversationTile
{
    [SerializeField]
    private Sprite demonIdle;
    [SerializeField]
    private Sprite demonSmug;

    [SerializeField]
    private GameObject demon;

    public override void initText()
    {
        
    }

    public override void dialogStart()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonSmug;
    }

    public override void dialogFinish()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIdle;
    }
}

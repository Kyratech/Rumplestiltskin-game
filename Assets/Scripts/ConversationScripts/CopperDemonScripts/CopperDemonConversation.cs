using UnityEngine;
using System.Collections;

public class CopperDemonConversation : ConversationTile
{
    [SerializeField]
    private Sprite copperIdle;
    [SerializeField]
    private Sprite copperTalk;
    [SerializeField]
    private Sprite copperAngry;
    [SerializeField]
    private GameObject copperDemon;
    [SerializeField]
    private GameObject badAfter;
    [SerializeField]
    private GameObject goodAfter;

    bool angered;

    public override void initText()
    {
        angered = false;
    }

    public override void dialogStart()
    {
        if(!angered)
            copperDemon.GetComponent<SpriteRenderer>().sprite = copperTalk;
    }

    public override void dialogFinish()
    {
        if (!angered)
        {
            copperDemon.GetComponent<SpriteRenderer>().sprite = copperIdle;
            setDialog(goodAfter);
        }
        else
        {
            copperDemon.GetComponent<SpriteRenderer>().sprite = copperAngry;
            setDialog(badAfter);
        }
    }

    public void setAngered(bool newAngered)
    {
        angered = newAngered;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EldritchDemonConversation : ConversationTile {
    [SerializeField]
    private Sprite eldritchIdle;
    [SerializeField]
    private Sprite eldritchTalk;
    [SerializeField]
    private GameObject eldritchDemon;

    bool firstInteract;

    public override void initText()
    {
        firstInteract = true;
    }

    public override void dialogStart()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchTalk;
    }

    public override void dialogFinish()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchIdle;
    }
}

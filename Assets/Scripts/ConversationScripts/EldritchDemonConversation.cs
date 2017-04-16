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
    [SerializeField]
    private GameObject dialogOptionBox;

    public override void initText()
    {
        //Nothing to do
    }

    public override void dialogStart()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchTalk;
    }

    public override void dialogFinish()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchIdle;
        dialogBox = dialogOptionBox;
    }
}

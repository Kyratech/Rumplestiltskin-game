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

    public override void initText()
    {
        List<string> lines = new List<string>();
        lines.Add("Mortal.");
        lines.Add("What are you doing here.");
        lines.Add("This is no place for your kind.");
        lines.Add("I will not hurt you.");
        lines.Add("However.");
        lines.Add("Whatever you seek.");
        lines.Add("Whatever your intentions.");
        lines.Add("Advice:");
        lines.Add("Give up.");
        lines.Add("It will end poorly.");
        lines.Add("Return to your own realm before it is too late.");

        this.setLines(lines);
    }

    public override void dialogStartInit()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchTalk;
    }

    public override void dialogFinishInit()
    {
        eldritchDemon.GetComponent<SpriteRenderer>().sprite = eldritchIdle;

        List<string> lines = new List<string>();
        lines.Add("Repeat advice:");
        lines.Add("Do not get involved in the affairs of demons.");

        this.setLines(lines);
    }
}

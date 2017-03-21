using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EldritchDemonConversation : ConversationTile {

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
}

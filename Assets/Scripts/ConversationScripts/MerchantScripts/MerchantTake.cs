﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MerchantTake : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
		lines.Add("Ah! I happened to pass the entrance to the ancient temple on my way into town.");
		lines.Add("I remember the way, but unfortunately...");
		lines.Add("I'm not very good at reversing directions, so i'll leave that to you.");
		lines.Add("I believe it was:");
        lines.Add("E-S-W-W-S-W");
        lines.Add("Good luck on your journey");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

//ESWWSW
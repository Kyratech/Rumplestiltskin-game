using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MerchantTake : DialogTextController
{
    // Use this for initialization
    void Start()
    {
		List<string> lines = new List<string>();
		lines.Add("Ah! I happened to pass the entrance to an ancient temple on my way into town,");
		lines.Add("You should definitely check it out.");
		lines.Add("I remember the way, but unfortunately...");
		lines.Add("I'm not very good at reversing directions, so i'll leave that to you.");
		lines.Add("I believe it was:");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

//ESWWSW
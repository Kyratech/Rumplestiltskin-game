using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HusbandIntro : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("You go and find that name. We won't find a nanny in such a short time, and I was never as clever as you.");
        lines.Add("I know you can do it - don't worry about us!");
        lines.Add("And take that occult textbook with you. I saw it somewhere in the house recently.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopperDemonBadDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("What is this?");
        lines.Add("You dare make a mockery our of me?");
        lines.Add("I care not for this element.");
        lines.Add("Keep it.");
        lines.Add("And begone.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

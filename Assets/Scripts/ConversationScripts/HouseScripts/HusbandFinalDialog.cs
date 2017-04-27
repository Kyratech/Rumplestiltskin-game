using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HusbandFinalDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("There is no time to waste! Get going, and return to us soon!");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

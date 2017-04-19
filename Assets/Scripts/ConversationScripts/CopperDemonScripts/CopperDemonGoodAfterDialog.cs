using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopperDemonGoodAfterDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("I wish you well on your quest, mortal.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

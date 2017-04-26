using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopperDemonGoodDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("A humble offering.\nBut acceptable.");
        lines.Add("You have earned my sympathy.");
        lines.Add("I shall look over you, mortal.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

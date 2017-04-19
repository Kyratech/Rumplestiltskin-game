using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonIntroDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("This is unexpected.");
        lines.Add("Mortal.");
        lines.Add("What are you doing here.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HusbandJokeDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Ha. Ha. Ha.");
        lines.Add("Honey, it's a DEMON.");
        lines.Add("I think we can both agree that these things aren't as nonsense as they once seemed.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

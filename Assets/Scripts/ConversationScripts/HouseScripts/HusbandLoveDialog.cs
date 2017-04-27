using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HusbandLoveDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Please don't be harsh on yourself.");
        lines.Add("It is clear that had you not agreed to its terms, we would never even have met.");
        lines.Add("I would not trade this life for anything.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

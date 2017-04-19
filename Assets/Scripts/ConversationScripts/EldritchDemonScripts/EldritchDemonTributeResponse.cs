using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonTributeResponse : DialogTextController
{

    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("An offering?");
        lines.Add("That is certainly one way to earn favours.");
        lines.Add("However.");
        lines.Add("Do not expect true loyalty.");
        lines.Add("Advice:");
        lines.Add("Each demon presides over one element.");
        lines.Add("And we do not like to share them.");

        this.setLines(lines);
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonTributeResponse : DialogTextController
{

    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("You should not worship our kind.");
        lines.Add("Though each Demon presides over a particular unique element.");
        lines.Add("We are not the source of your wealths.");
        lines.Add("Rather.");
        lines.Add("It is merely an exercise in vanity.");
        lines.Add("Advice:");
        lines.Add("You have nothing to thank Demons for.");
        lines.Add("Abandon this foolish endeavor.");

        this.setLines(lines);
    }
}

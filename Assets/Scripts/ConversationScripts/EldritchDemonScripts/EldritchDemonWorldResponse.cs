using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonWorldResponse : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("...");
        lines.Add("The realm of the Demons.");
        lines.Add("Is no place for mortal kind.");
        lines.Add("Advice:");
        lines.Add("Leave.");
        lines.Add("This will end poorly.");
        lines.Add("Return to your own realm before it is too late.");

        this.setLines(lines);
    }
}

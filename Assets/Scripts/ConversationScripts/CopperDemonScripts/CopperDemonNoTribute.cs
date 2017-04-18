using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopperDemonNoTribute : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Nothing.");
        lines.Add("Then, do not expect any mercy from me, mortal.");

        this.setLines(lines);
    }
}

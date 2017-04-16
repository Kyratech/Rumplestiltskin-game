using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopperDemonBadAfterDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("I am not interested.");

        this.setLines(lines);
    }
}

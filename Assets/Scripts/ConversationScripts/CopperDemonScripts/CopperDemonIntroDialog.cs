using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CopperDemonIntroDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Excellent.");
        lines.Add("Another mortal joins the fold.");
        lines.Add("Well, then?");
        lines.Add("Do you bring your tribute?");
        lines.Add("It is of course, only fair.");
        lines.Add("One must respect their betters.");

        this.setLines(lines);
    }
}

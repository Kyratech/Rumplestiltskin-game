using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BookcaseIntroDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("I don't really read fiction books.\nRomance, Mystery, 'The Occult'.\n");
        lines.Add("...That last one belongs to Ricardo.");
        lines.Add("(Take the book?)");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

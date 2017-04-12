using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BookcaseIntroDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("I don't really read fiction books.\nRomance, Mystery, Alchemy.\nWhy do I even have these?");
        lines.Add("Hmm. That last one. I'd say it's nonsense, but I saw that...thing with my own two eyes.");
        lines.Add("(Take the book?)");

        this.setLines(lines);
    }
}

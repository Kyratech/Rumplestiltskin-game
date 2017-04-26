using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BookLeaveDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("(Decided to leave the book where it is)");
        lines.Add("Whatever I saw, this is still nonsense!");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

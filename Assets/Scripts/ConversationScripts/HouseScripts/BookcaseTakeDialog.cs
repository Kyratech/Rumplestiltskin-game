using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BookcaseTakeDialog : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("(Book added to inventory)");

        this.setLines(lines);
    }
}

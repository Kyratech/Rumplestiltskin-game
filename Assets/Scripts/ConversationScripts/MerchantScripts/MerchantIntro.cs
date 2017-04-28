using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MerchantIntro : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Good day, Miss.");
        lines.Add("How may I help you?");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

//ESWWSW
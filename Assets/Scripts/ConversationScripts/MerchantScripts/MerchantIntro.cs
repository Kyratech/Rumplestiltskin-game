using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MerchantIntro : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Good Day Miss.");
        lines.Add("How Many I Help You?");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

//ESWWSW
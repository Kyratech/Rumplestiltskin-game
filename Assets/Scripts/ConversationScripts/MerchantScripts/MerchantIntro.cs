using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MerchantIntro : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Hello.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

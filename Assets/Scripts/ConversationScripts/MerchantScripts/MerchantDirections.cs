using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantDirections : DialogTextController {

	void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("E-S-W-W-S-W");
        lines.Add("Good luck on your journey");

        this.setLines(lines);
    }

    public override void extraSetup() { }

}
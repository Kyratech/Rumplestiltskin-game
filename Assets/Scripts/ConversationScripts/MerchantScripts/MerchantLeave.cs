using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MerchantLeave : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Another time then...");
        lines.Add("Have a nice day.");
        lines.Add("[The Merchant looks sad to see you leave]");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

//ESWWSW
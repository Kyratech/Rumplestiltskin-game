using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonNameResponse : DialogTextController
{
    // Use this for initialization
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("The name of a Demon.");
        lines.Add("Wield it, and one has power over the Demon.");
        lines.Add("Only one Demon is arrogant enough to challenge you in such a way.");
        lines.Add("They can be found to the north of this region.");  
        lines.Add("You would not be the first mortal to attempt this quest.");
        lines.Add("It is not my place to help you.");
        lines.Add("But.");
        lines.Add("Perhaps you can learn from mortals who have come before.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

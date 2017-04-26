using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IronDemonIntroDialog : DialogTextController
{
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("You wish to travel north?");
        lines.Add("Then the bridge must be raised.");
        lines.Add("To raise the bridge:");
        lines.Add("Light the beacons by the dark.");
        lines.Add("Quell the beacons near the light.");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

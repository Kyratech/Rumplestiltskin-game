using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IronDemonFollowupDialog : DialogTextController
{
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("To raise the bridge:");
        lines.Add("Light the beacons by the dark.");
        lines.Add("Quell the beacons near the light.");
        lines.Add("What? Are you offering something?");

        this.setLines(lines);
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IronDemonNothingOption : DialogTextController
{
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("You have nothing to offer.");
        lines.Add("Regardless:");
        lines.Add("Light the beacons by the dark.");
        lines.Add("Quell the beacons near the light.");

        this.setLines(lines);
    }
}

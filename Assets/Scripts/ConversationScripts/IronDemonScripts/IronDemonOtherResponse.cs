using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IronDemonOtherResponse : DialogTextController
{
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Good attempt, but I am not interested.");
        lines.Add("Repeat:");
        lines.Add("Light the beacons by the dark.");
        lines.Add("Quell the beacons near the light.");

        this.setLines(lines);
    }
}

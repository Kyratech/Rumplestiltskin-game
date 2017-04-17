using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IronDemonIronResponse : DialogTextController
{
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("A fine offering.");
        lines.Add("Then, an clarification:");
        lines.Add("The crystals in this area are beacons.");
        lines.Add("Each beacon is near to a dark-leaf tree or a light-leaf tree.");
        lines.Add("Light the beacons by the dark.");
        lines.Add("Quell the beacons near the light.");

        this.setLines(lines);
    }
}

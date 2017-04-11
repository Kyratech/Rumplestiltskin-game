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
        lines.Add("Observation:");
        lines.Add("Your Demon is as foolish as you are.");
        lines.Add("With arrogance like that.");
        lines.Add("It likely has left clues out in the open.");
        lines.Add("To make it more delicious.");
        lines.Add("When you fail.");

        this.setLines(lines);
    }
}

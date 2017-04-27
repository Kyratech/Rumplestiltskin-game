using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonGoodEndDialogThree : DialogTextController
{
    [SerializeField]
    private Sprite demonIcon;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("You guessed.");
        lines.Add("Do not try to fool me.");
        lines.Add("I can read the uncertainty in your face.");
        lines.Add("And yet, with my name.");
        lines.Add("I cannot lay a hand upon you.");
        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIcon;
    }
}

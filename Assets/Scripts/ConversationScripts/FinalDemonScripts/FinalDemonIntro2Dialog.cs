using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonIntro2Dialog : DialogTextController
{
    [SerializeField]
    private Sprite demonLaugh;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Because.");
        lines.Add("I am thinking.");
        lines.Add("That once this is finished.");
        lines.Add("It will be I that has the last laugh.");
        lines.Add("So.");
        lines.Add("Are we ready?");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonLaugh;
    }
}

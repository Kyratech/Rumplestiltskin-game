using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonReady2Dialog : DialogTextController
{
    [SerializeField]
    private Sprite demonSmug;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("MORTAL.");
        lines.Add("What.");
        lines.Add("Is my name?");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonSmug;
    }
}
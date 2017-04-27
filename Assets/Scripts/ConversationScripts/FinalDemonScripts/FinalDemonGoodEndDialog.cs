using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonGoodEndDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonIdle;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Eh, you win but you guessed so screw you.");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIdle;
    }
}

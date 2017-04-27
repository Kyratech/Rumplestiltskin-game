using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBadEndDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonIdle;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Kekekekek you lose.");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIdle;
    }
}

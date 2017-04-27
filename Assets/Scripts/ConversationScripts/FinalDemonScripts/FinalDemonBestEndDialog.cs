using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBestEndDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonIdle;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Lol, you win.");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIdle;
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonReadyDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonLaugh;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Excellent!");
        lines.Add("Then let's begin!");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonLaugh;
    }
}

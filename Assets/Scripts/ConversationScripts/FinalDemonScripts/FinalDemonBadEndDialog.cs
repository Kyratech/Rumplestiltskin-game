using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBadEndDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonSmug;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Oh dear.");
        lines.Add("I am afraid that you are incorrect.");
        lines.Add("Commiserations, ecetera.");
        lines.Add("I was so hoping that you could do this.");
        lines.Add("I would have been proud.");
        lines.Add("Oh well.");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonSmug;
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonGoodEndDialogTwo : DialogTextController
{
    [SerializeField]
    private Sprite demonIcon;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("YOU");
        lines.Add("DID");
        lines.Add("NOT");
        lines.Add("SOLVE");
        lines.Add("IT");
        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIcon;
    }
}

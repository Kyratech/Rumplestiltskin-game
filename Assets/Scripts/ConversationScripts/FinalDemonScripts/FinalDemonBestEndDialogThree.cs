using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBestEndDialogThree : DialogTextController
{
    [SerializeField]
    private Sprite demonIcon;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Off with you.");
        lines.Add("I must find someone else to play with.");
        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIcon;
    }
}

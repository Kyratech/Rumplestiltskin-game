using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBadEndDialogThree : DialogTextController
{
    [SerializeField]
    private Sprite demonIcon;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Speaking of which.");
        lines.Add("A deal is a deal.");
        lines.Add("I will be sure to send you family your kind regards.");
        lines.Add("Goodbye.");
        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIcon;
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonGoodEndDialogFour : DialogTextController
{
    [SerializeField]
    private Sprite demonIcon;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Get out of my sight.");
        lines.Add("We have no further business together.");
        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIcon;
    }
}

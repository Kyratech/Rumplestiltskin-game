using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBestEndDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonFrustrated;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("...");
        lines.Add("Well there it is.");
        lines.Add("And not even a hint of doubt.");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonFrustrated;
    }
}

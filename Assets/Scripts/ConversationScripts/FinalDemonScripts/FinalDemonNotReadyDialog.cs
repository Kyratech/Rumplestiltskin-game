using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonNotReadyDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonSmug;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Of course you are not.");
        lines.Add("The deadline approaches.");
        lines.Add("Do not keep me waiting.");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonSmug;
    }
}

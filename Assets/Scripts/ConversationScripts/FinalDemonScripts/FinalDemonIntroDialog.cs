using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonIntroDialog : DialogTextController
{
    [SerializeField]
    private Sprite demonSmug;
    [SerializeField]
    private GameObject demon;
    
    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("Here at last.");
        lines.Add("Well, did you have fun?");

        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonSmug;
    }
}

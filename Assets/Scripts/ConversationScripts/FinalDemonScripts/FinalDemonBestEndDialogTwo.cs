using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FinalDemonBestEndDialogTwo : DialogTextController
{
    [SerializeField]
    private Sprite demonIcon;
    [SerializeField]
    private GameObject demon;

    void Start()
    {
        List<string> lines = new List<string>();
        lines.Add("It is nice to have underestimated a mortal for a change.");
        lines.Add("Yes, you are quite an impressive specimen.");
        lines.Add("Very canny, indeed!");
        lines.Add("...");
        lines.Add("Now.");
        this.setLines(lines);
    }

    public override void extraSetup()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonIcon;
    }
}

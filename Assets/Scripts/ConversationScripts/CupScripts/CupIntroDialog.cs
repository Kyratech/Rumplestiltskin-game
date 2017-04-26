using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CupIntroDialog : DialogTextController
{
	enum Contents {Copper, Iron, Mercury, Key};
	[SerializeField]
	Contents contents;

    // Use this for initialization
    void Start()
    {	
    	string action = "Take";
    	string itemName;
    	switch(contents) {
		case Contents.Copper:
    	 	itemName = "pile of copper coins";
    	 	break;
		case Contents.Iron:
    	 	itemName = "shard of iron";
    	 	break;
		case Contents.Mercury:
    	 	itemName = "bowl of quicksilver";
    	 	break;
    	 case Contents.Key:
    	 	action = "Flip";
    	 	itemName = "switch";
    	 	break;
		default:
    	 	itemName = "ERROR";
    	 	break;
    	}
        List<string> lines = new List<string>();
        lines.Add("What's this?");
        lines.Add("Hmm... Looks like a " + itemName);
        lines.Add("(" + action + " the " + itemName + "?)");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

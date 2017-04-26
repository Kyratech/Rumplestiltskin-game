using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CupLeave : DialogTextController
{
	enum Contents {Copper, Iron, Mercury, Key};
	[SerializeField]
	Contents contents;

    // Use this for initialization
    void Start()
    {	
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
    	 	itemName = "switch";
    	 	break;
    	 default:
    	 	itemName = "ERROR";
    	 	break;
    	}
        List<string> lines = new List<string>();
        lines.Add("You decide to leave the " + itemName + ".");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

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
    	string demonName;
    	switch(contents) {
		case Contents.Copper:
    	 	itemName = "pile of copper coins";
    	 	demonName = "Beezlebub";
    	 	break;
		case Contents.Iron:
			itemName = "shard of iron";
    	 	demonName = "Belphegor";
    	 	break;
		case Contents.Mercury:
			itemName = "bowl of quicksilver";
    	 	demonName = "Mammon";
    	 	break;
    	 case Contents.Key:
    	 	action = "Flip";
			itemName = "switch";
    	 	demonName = "Sathanus";
    	 	break;
		default:
    	 	itemName = "ERROR";
    	 	demonName = "ERROR";
    	 	break;
    	}
        List<string> lines = new List<string>();
        lines.Add("What's this?");
        lines.Add("An offering to " + demonName);
        lines.Add("Hmm... Looks like a " + itemName);
        lines.Add("(" + action + " the " + itemName + "?)");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

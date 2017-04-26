using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CupIntroDialog : DialogTextController
{
	enum Metal {Copper, Iron, Mercury, Empty};
	[SerializeField]
	Metal contents;

    // Use this for initialization
    void Start()
    {	
    	string itemName;
    	switch(contents) {
    	 case Metal.Copper:
    	 	itemName = "copper coins";
    	 	break;
    	 case Metal.Iron:
    	 	itemName = "iron shard";
    	 	break;
    	 case Metal.Mercury:
    	 	itemName = "quicksilver";
    	 	break;
    	 default:
    	 	itemName = "it's empty";
    	 	break;
    	}
        List<string> lines = new List<string>();
        lines.Add("What's this?");
        lines.Add("Hmm... Looks like " + itemName);
        lines.Add("(Take the " + itemName + "?)");

        this.setLines(lines);
    }

    public override void extraSetup() { }
}

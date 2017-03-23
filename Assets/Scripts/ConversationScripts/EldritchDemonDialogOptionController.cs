using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EldritchDemonDialogOptionController : DialogOptionController
{
    [SerializeField]
    GameObject eldritchDemonConversationGameObject;

    /*
    * Set the demon's lines based on player response
    */
    public override void selectOption(int option)
    {
        List<string> lines = new List<string>();

        switch (option)
        {
            //"Come to find demon name"
            case 0:
                lines.Add("The name of a Demon.");
                lines.Add("Wield it, and one has power over the Demon.");
                lines.Add("Observation:");
                lines.Add("Your Demon is as foolish as you are.");
                lines.Add("With arrogance like that.");
                lines.Add("It likely has left clues out in the open.");
                lines.Add("To make it more delicious.");
                lines.Add("When you fail.");
                break;
            //"Learn about the world"
            case 1:
                lines.Add("...");
                lines.Add("The realm of the Demons.");
                lines.Add("Is no place for mortal kind.");
                lines.Add("Advice:");
                lines.Add("Leave.");
                lines.Add("This will end poorly.");
                lines.Add("Return to your own realm before it is too late.");
                break;
            //"Pay tribute"
            case 2:
                lines.Add("You should not worship our kind.");
                lines.Add("Though each Demon presides over a particular unique element.");
                lines.Add("We are not the source of your wealths.");
                lines.Add("Rather.");
                lines.Add("It is merely an exercise in vanity.");
                lines.Add("Advice:");
                lines.Add("You have nothing to thank Demons for.");
                lines.Add("Abandon this foolish endeavor.");
                break;
        }


        ConversationTile convo = eldritchDemonConversationGameObject.GetComponent<ConversationTile>();
        convo.setLines(lines);
        convo.accessTriggerable = true;
        convo.toggleDialog();
    }
}

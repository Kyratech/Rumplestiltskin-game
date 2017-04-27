using UnityEngine;
using System.Collections;

/*
 * Don't need anything fancy for this one
 */
public class MerchantConversation : ConversationTile
{
	[SerializeField]
    GameObject dialogOption;

    public override void initText() { }

    public override void dialogStart() { }

    public override void dialogFinish()
    {
        dialogBox = dialogOption;
    }
}

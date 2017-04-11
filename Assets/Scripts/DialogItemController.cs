using UnityEngine;
using System.Collections;


/*
 * Dialog items are either text boxes or dialog option lists
 * They should advance through the contents of the item,
 * and then activate the next item in the chain.
 */
public abstract class DialogItemController : MonoBehaviour
{
    //The gameobject of the next item in the chain
    [SerializeField]
    protected GameObject nextDialog;

    /*
     * Show the next line of dialog
     * or advance to the next dialog object
     * Conversation argument is the inspectTile that triggered the convo
     */
    public abstract void showNext(ConversationTile conversation);
}

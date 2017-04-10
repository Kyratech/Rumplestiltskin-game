using UnityEngine;
using System.Collections;


/*
 * Dialog items are either text boxes or dialog option lists
 * They should advance through the contents of the item,
 * and then activate the next item in the chain.
 */
public abstract class DialogItemController : MonoBehaviour
{
    //The gameobject that displays this dialog item
    [SerializeField]
    private GameObject myDialog;
    //The gameobject of the next item in the chain
    [SerializeField]
    protected GameObject nextDialog;

    /*
     * Show the next line of dialog
     * or advance to the next dialog object
     */
    public abstract void showNext();
}

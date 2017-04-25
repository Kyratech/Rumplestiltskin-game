using UnityEngine;
using System.Collections;

/*
 * Persists throughout the course of the game.
 * Keeps track of inventory
 * and narrative engine progress
 * Eg: Which characters spoken to + which dialog option, etc.
 */
public class GameController : MonoBehaviour
{
    //Inventory
    public bool hasBook;
    public bool hasCopper;
    public bool hasIron;
    public bool hasMercury;

    //Game progress
    public bool completedDemonBridge;

    //Level warp data - find where to put player in next level
    public int warpID;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        warpID = 0;
    }

    // Use this for initialization
    void Start()
    {
        hasBook = false;

        //TODO: Eventually should not start with these
        hasCopper = true;
        hasIron = true;
        hasMercury = true;        

        completedDemonBridge = false;
    }
}

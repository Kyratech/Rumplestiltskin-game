using UnityEngine;
using System.Collections;

/*
 * Persists throughout the course of the game.
 * Keeps track of inventory
 * and narrative engine progress
 * Eg: Which characters spoken to + which dialog option, etc.
 */
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
	public string sceneToDestroy;

    public enum metals
    {
        copper,
        iron,
        mercury
    };

    //Inventory
	public bool hasBook;
    public bool hasCopper;
    public bool hasIron;
    public bool hasMercury;
	public bool hasKey;
    public bool hasCopperName;
    public bool hasIronName;
    public bool hasMercuryName;
    public bool hasKeyName;
    public bool hasDirections;
    public bool metCopperDemon;
    public metals copperMetal;
    public bool metIronDemon;
    public metals ironMetal;
    public bool readDemonTablet;

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

        hasCopper = false;
        hasIron = false;
        hasMercury = false;
        hasKey = false;


    	hasCopperName = false;
    	hasIronName = false;
    	hasMercuryName = false;
    	hasKeyName = false;
       	
        metCopperDemon = false;
        metIronDemon = false;
        readDemonTablet = false;       

        completedDemonBridge = false;
    }

    void Update() {
		if (SceneManager.GetActiveScene().name == sceneToDestroy || SceneManager.GetActiveScene().name == "Game_Over")
			Destroy(gameObject);
    }
}

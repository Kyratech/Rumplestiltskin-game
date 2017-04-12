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
    private bool hasBook;

    public bool HasBook { get; set; }
        
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start()
    {
        hasBook = false;
    }
}

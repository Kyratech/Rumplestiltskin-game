using UnityEngine;
using System.Collections;

public class SceneWarp : MonoBehaviour
{
    [SerializeField]
    protected string sceneToLoad;

    //Which warp to spawn at in the next level
    [SerializeField]
    protected int warpID;
    protected GameController controller;

    void Start()
    {
        GameObject gameController = GameObject.Find("GameManager");
        controller = gameController.GetComponent<GameController>();
    }
}

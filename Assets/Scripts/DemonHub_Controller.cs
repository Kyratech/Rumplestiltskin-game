using UnityEngine;
using System.Collections;

public class DemonHub_Controller : MonoBehaviour
{
    //Deal with the beacon puzzle
    [SerializeField]
    private GameObject northBlocker;
    private GameObject[] beacons;
    private bool beaconsCorrect;
    private GameObject[] platforms;
    private Vector3[] platformStarts;   //Position where platforms start
    private Vector3[] platformTargets;  //Position where platforms should move to
    private float platformMoveTimer;
    private float platformMoveDuration = 2.0f;

    void Start()
    {
        beacons = GameObject.FindGameObjectsWithTag("DemonBeacon");

        beaconsCorrect = false;

        platforms = GameObject.FindGameObjectsWithTag("DemonPlatform");
        platformStarts = new Vector3[platforms.Length];
        platformTargets = new Vector3[platforms.Length];
        for(int i = 0; i < platforms.Length; i++)
        {
            platformStarts[i] = platforms[i].transform.position;
            platformTargets[i] = platforms[i].transform.position + new Vector3(0.0f, 7.0f, 0.0f);
            //Debug.Log("Platform at: " + platformStarts[i] + " has target at:" + platformTargets[i]);
        }

        platformMoveTimer = 0;

        //This is slow as heck! Only in use because this is a game jam sort of scenario.
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        if(gameController.CompletedDemonBridge)
        {
            beaconsCorrect = true;

            northBlocker.SetActive(false);
        }
    }

    void Update()
    {
        if(beaconsCorrect && platformMoveTimer < platformMoveDuration)
        {
            float moveFraction = platformMoveTimer / platformMoveDuration;

            for (int i = 0; i < platforms.Length; i++)
            {
                FloatAnimation platformController = platforms[i].GetComponent<FloatAnimation>();
                platformController.setInitialPosition(Vector3.Lerp(platformStarts[i], platformTargets[i], moveFraction));
            }

            platformMoveTimer += Time.deltaTime;
        }
    }

    public void updateBeacons()
    {
        bool allCorrect = true;
        foreach(GameObject beacon in beacons)
        {
            DemonBeaconController beaconController = beacon.GetComponent<DemonBeaconController>();
            if(!beaconController.getCorrect())
            {
                allCorrect = false;
                break;
            }
        }

        if(allCorrect)
        {
            Debug.Log("All correct");
            beaconsCorrect = true;

            northBlocker.SetActive(false);

            //This is slow as heck! Only in use because this is a game jam sort of scenario.
            GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
            gameController.CompletedDemonBridge = true;
        }
    }
}

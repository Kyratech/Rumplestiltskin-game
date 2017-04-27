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

    [SerializeField]
    private GameObject cameraObj;
    [SerializeField]
    private GameObject player;

    private AudioSource audioSource;

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
        if(gameController.completedDemonBridge)
        {
            beaconsCorrect = true;

            northBlocker.SetActive(false);
        }

        audioSource = GetComponent<AudioSource>();
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
        else if(beaconsCorrect && platformMoveTimer < platformMoveDuration + 1.0f)
        {
            platformMoveTimer += Time.deltaTime;

            if(platformMoveTimer >= platformMoveDuration + 1.0f)
            {
                cameraObj.GetComponent<CameraFollow>().setTarget(player.transform);
                player.GetComponent<PlayerMovement>().setInteracting(false);
            }
        }
    }

    public void updateBeacons()
    {
        //If the puzzle was previously solved, then it cannot be unsolved
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
        if (!gameController.completedDemonBridge)
        {
            bool allCorrect = true;
            foreach (GameObject beacon in beacons)
            {
                DemonBeaconController beaconController = beacon.GetComponent<DemonBeaconController>();
                if (!beaconController.getCorrect())
                {
                    allCorrect = false;
                    break;
                }
            }

            if (allCorrect && gameController)
            {
                Debug.Log("All correct");
                beaconsCorrect = true;

                northBlocker.SetActive(false);

                audioSource.Play();

                //Look at the centre platform
                cameraObj.GetComponent<CameraFollow>().setTarget(platforms[1].transform);
                player.GetComponent<PlayerMovement>().setInteracting(true);

                gameController.completedDemonBridge = true;
            }
        }
    }
}

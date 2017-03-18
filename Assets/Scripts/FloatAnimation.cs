using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Attach this script to a gameobject to get it to bob up and down
 */
public class FloatAnimation : MonoBehaviour
{
    //Distance in unity units that the object will go above/below initial position
    [SerializeField]
    private float distance;
    //Speed of bob
    [SerializeField]
    private float speed;

    private Vector3 initialPosition;
    private Transform myTransform;
    private float timer;

	// Use this for initialization
	void Start ()
    {
        myTransform = gameObject.transform;
        initialPosition = myTransform.position;
        timer = 0;
	}
	
	// Bob up and down based on a sin pattern
	void Update ()
    {
        timer += speed * Time.deltaTime;
        //Clamp to 0 <= timer < 360 to avoid the inevitable overflow
        if (timer >= Mathf.PI * 2)
        {
            timer -= Mathf.PI * 2;
        }

        float deltaY = distance * Mathf.Sin(timer);
        myTransform.position = initialPosition + new Vector3(0, deltaY, 0);
	}
}

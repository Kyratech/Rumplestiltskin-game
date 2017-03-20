using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Very hacky way of getting an object to simulate parallax scrolling
 */
public class ParallaxController : CameraFollow {
    [SerializeField]
    private float scrollSpeed = 0.5f;

    //Parent gameobject of all objects to move with the camera
    [SerializeField]
    private GameObject scrollLayer;

    private Transform layerTransform;

	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
        layerTransform = scrollLayer.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
        mycam.orthographicSize = Screen.height / 100f;

        
        if (target)
        {
            Vector3 cameraNewPos =  Vector3.Lerp(transform.position, target.position + new Vector3(0, 0, -10), cameraSpeed);
            Vector3 cameraTranslation = cameraNewPos - transform.position;

            //Move camera
            transform.position = cameraNewPos;
            //Move parallax layer
            layerTransform.Translate(cameraTranslation * scrollSpeed, Space.World);
        }

        
    }
}

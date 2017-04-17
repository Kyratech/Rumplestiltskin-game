using UnityEngine;
using System.Collections;

public class DemonBeaconController : InspectTile
{
    [SerializeField]
    private Sprite lightSprite;
    [SerializeField]
    private Sprite darkSprite;
    [SerializeField]
    private bool activated;
    [SerializeField]
    private bool targetActivated;

    private DemonHub_Controller hubController;

    void Start()
    {
        pauseTimer = 0.0f;

        GameObject controllerObj = GameObject.Find("DemonHub_Controller");
        hubController = controllerObj.GetComponent<DemonHub_Controller>();
    }

    public override bool toggleDialog()
    {
        activated = !activated;
        if (activated)
            transform.gameObject.GetComponent<SpriteRenderer>().sprite = lightSprite;
        else
            transform.gameObject.GetComponent<SpriteRenderer>().sprite = darkSprite;

        hubController.updateBeacons();

        //Don't lock the player into an interaction
        return false;
    }

    public bool getCorrect()
    {
        return (activated == targetActivated);
    }

    public void setCorrect()
    {
        if (targetActivated)
            transform.gameObject.GetComponent<SpriteRenderer>().sprite = lightSprite;
        else
            transform.gameObject.GetComponent<SpriteRenderer>().sprite = darkSprite;
    }
}

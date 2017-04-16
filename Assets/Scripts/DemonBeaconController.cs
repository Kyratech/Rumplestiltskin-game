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

    public override bool toggleDialog()
    {
        activated = !activated;
        if (activated)
            transform.gameObject.GetComponent<SpriteRenderer>().sprite = lightSprite;
        else
            transform.gameObject.GetComponent<SpriteRenderer>().sprite = darkSprite;

        //Don't lock the player into an interaction
        return false;
    }
}

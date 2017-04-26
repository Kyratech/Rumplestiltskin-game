using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    GameObject bookIcon;
    [SerializeField]
    GameObject copperIcon;
    [SerializeField]
    GameObject ironIcon;
    [SerializeField]
    GameObject mercuryIcon;
    [SerializeField]
    GameObject copperScribble;
    [SerializeField]
    GameObject ironScrible;
    [SerializeField]
    GameObject demonScribble;

    public bool ToggleVisible()
    {
        GameObject thisObject = transform.gameObject;
        if(!thisObject.activeInHierarchy)
        {
            thisObject.SetActive(true);

            updateInventory();
            
        }
        else
        {
            thisObject.SetActive(false);
        }

        return thisObject.activeInHierarchy;
    }

    private void updateInventory()
    {
        //This is slow as heck! Only in use because this is a game jam sort of scenario.
        GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();

        bookIcon.SetActive(gameController.hasBook);
        copperIcon.SetActive(gameController.hasCopper);
        ironIcon.SetActive(gameController.hasIron);
        mercuryIcon.SetActive(gameController.hasMercury);

        copperScribble.SetActive(gameController.metCopperDemon);
        if (gameController.metCopperDemon)
        {
            Text copperText = copperScribble.GetComponent<Text>();
            switch (gameController.copperMetal)
            {
                case GameController.metals.copper:
                    copperText.text = "THIS UGLY THING\nLIKES COPPER";
                    break;
                case GameController.metals.iron:
                    copperText.text = "THIS UGLY THING\nDOESNT LIKE IRON";
                    break;
                case GameController.metals.mercury:
                    copperText.text = "THIS UGLY THING\nDOESNT LIKE MERCURY";
                    break;
            }
        }
            
        ironScrible.SetActive(gameController.metIronDemon);
        demonScribble.SetActive(gameController.readDemonTablet);
    }
}

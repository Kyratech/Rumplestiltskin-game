using UnityEngine;
using System.Collections;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    GameObject bookIcon;

    public bool ToggleVisible()
    {
        GameObject thisObject = transform.gameObject;
        if(!thisObject.activeInHierarchy)
        {
            thisObject.SetActive(true);

            //This is slow as heck! Only in use because this is a game jam sort of scenario.
            GameController gameController = GameObject.Find("GameManager").GetComponent<GameController>();
            bookIcon.SetActive(gameController.HasBook);
        }
        else
        {
            thisObject.SetActive(false);
        }

        return thisObject.activeInHierarchy;
    }
}

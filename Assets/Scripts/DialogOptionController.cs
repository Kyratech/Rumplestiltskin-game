using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public abstract class DialogOptionController : MonoBehaviour
{
    //Dialog Options
    private List<GameObject> options;
    private int activeOption;

    bool axisInUse;

    // Use this for initialization
    void Start()
    {
        axisInUse = false;

        options = new List<GameObject>();
        //Get all the dialog options
        foreach(Transform child in transform)
        {
            options.Add(child.gameObject);
        }

        activeOption = 0;

        options[activeOption].GetComponent<Toggle>().isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Scroll through the options
        float value;
        //Get one input of axis - like 'buttonDown'
        if((value = Input.GetAxisRaw("Vertical")) != 0)
        {
            if(!axisInUse)
            {
                axisInUse = true;

                //Increment or decrement the active option
                if(value < 0)
                {
                    activeOption = activeOption - 1;
                    //Wrap selected option
                    if (activeOption < 0)
                        activeOption += options.Count;
                }
                else
                {
                    activeOption = (activeOption + 1) % options.Count;
                }

                options[activeOption].GetComponent<Toggle>().isOn = true;
            }
        }
        else
        {
            axisInUse = false;
        }

        //Select an option
        if(Input.GetButtonDown("Inspect"))
        {
            selectOption(activeOption);
            this.gameObject.SetActive(false);
        }
    }

    /*
     * Do something with the selected option
     */
    public abstract void selectOption(int option);
}

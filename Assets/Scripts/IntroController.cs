using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * The hackiest game intro cutscene made by man
 */
public class IntroController : MonoBehaviour {
    [SerializeField]
    private GameObject mainTextObject;
    private Text mainText;

    [SerializeField]
    private GameObject mainBlackout;
    private Image blackImage;
    private bool blackoutFadedIn = false;

    [SerializeField]
    private GameObject demonIntro;
    private Image demonImage;
    private bool demonFadeIn = false;
    [SerializeField]
    private Sprite demonSmile;

    [SerializeField]
    private GameObject demonBackground;
    [SerializeField]
    private GameObject demonBlackout;
    private Image dBlackoutImage;

    public GameObject demonScript1;
    public GameObject demonScript2;
    public GameObject demonScript3;
    public GameObject demonScript4;

    private List<string> introLines;
    private int lineCounter;

    private float timer;

    private int state;

    void Start()
    {
        mainText = mainTextObject.GetComponent<Text>();
        blackImage = mainBlackout.GetComponent<Image>();
        demonImage = demonIntro.GetComponent<Image>();
        dBlackoutImage = demonBlackout.GetComponent<Image>();

        introLines = new List<string>();
        introLines.Add("The year is 18XX.");
        introLines.Add("A young lady of science is held against her will.");
        introLines.Add("Tasked with transmuting base metals into gold.");
        introLines.Add("Alchemy.");
        introLines.Add("Beyond the grasp of mortal science.");
        introLines.Add("But not all knowledge belongs to mortal-kind.");
        introLines.Add("");

        lineCounter = 0;
        state = 0;
    }

	// Update is called once per frame
	void Update ()
    {
        //Use esc to bring up the inventory screen
        if (Input.GetButtonDown("Escape"))
        {
            NextScene();
        }

        timer += Time.deltaTime;

        if (state == 0 && lineCounter < introLines.Count - 1)
        {
            fadeText();

            if(blackoutFadedIn)
            {
                blackoutFadedIn = fadeIn(blackImage);
            }

            if(demonFadeIn)
            {
                demonFadeIn = fadeIn(demonImage);
            }
        }
        else if(state == 1)
        {
            fadeIn(demonBackground.GetComponent<Image>());

            if (timer > 2.0f)
            {
                demonScript1.SetActive(true);
            }
            
            if(timer > 5.0f)
            {
                demonScript2.SetActive(true);
            }

            if(timer > 8.0f)
            {
                demonScript3.SetActive(true);
            }

            if (timer > 11.0f)
            {
                demonImage.sprite = demonSmile;

                demonScript1.SetActive(false);
                demonScript2.SetActive(false);
                demonScript3.SetActive(false);
                demonScript4.SetActive(true);
            }

            if (timer > 15.0f)
            {
                dBlackoutImage.color = new Color(dBlackoutImage.color.r, dBlackoutImage.color.r, dBlackoutImage.color.r, timer - 15.0f);
            }

            if(timer > 16.0f)
            {
                dBlackoutImage.color = new Color(dBlackoutImage.color.r, dBlackoutImage.color.r, dBlackoutImage.color.r, 1.0f);
                timer = 0.0f;
                state = 2;
            }
        }
    }

    private void fadeText()
    {
        if (timer > 1.0f && timer < 2.0f)
            mainText.color = new Color(mainText.color.r, mainText.color.r, mainText.color.r, timer - 1.0f);
        else if (timer > 4.0f && timer <= 5.0f)
            mainText.color = new Color(mainText.color.r, mainText.color.r, mainText.color.r, 5.0f - timer);
        else if(timer > 5.0f)
        {
            mainText.color = new Color(mainText.color.r, mainText.color.r, mainText.color.r, 0.0f);
            timer = 0.0f;
            mainText.text = introLines[++lineCounter];

            if (lineCounter == 3)
                blackoutFadedIn = true;
            else if (lineCounter == 5)
                demonFadeIn = true;
            else if (lineCounter == introLines.Count - 1)
            {
                Debug.Log("Changed state");
                state = 1;
            }
        }
    }

    private bool fadeIn(Image img)
    {
        img.color = new Color(img.color.r, img.color.r, img.color.r, timer);

        if (timer > 1.0)
        {
            img.color = new Color(img.color.r, img.color.r, img.color.r, 1.0f);
            return false;
        }

        return true;
    }

    private void NextScene()
    {
        SceneManager.LoadScene("House");
    }
}

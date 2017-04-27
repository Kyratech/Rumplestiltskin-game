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

    [SerializeField]
    private GameObject bedroomBackground;
    private Animator bedroomAnim;

    [SerializeField]
    private GameObject bedroomDemon;
    private Animator bedroomDemonAnim;

    public GameObject demonScript5;
    public GameObject demonScript6;
    public GameObject demonScript7;
    public GameObject demonScript8;

    public GameObject demonScriptFinal;

    [SerializeField]
    private GameObject finalFadeout;
    private Image finalBlackoutImage;

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
        bedroomAnim = bedroomBackground.GetComponent<Animator>();
        bedroomDemonAnim = bedroomDemon.GetComponent<Animator>();
        finalBlackoutImage = finalFadeout.GetComponent<Image>();

        bedroomBackground.SetActive(false);
        bedroomAnim.speed = 0;
        bedroomDemon.SetActive(false);
        bedroomDemonAnim.speed = 0;

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

        if (state == 0)
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
                lineCounter = 0;
                introLines = new List<string>();
                introLines.Add("Years later...");
                introLines.Add("The demon comes to collect its prize.");
                introLines.Add("The young family pleads for mercy...");
                introLines.Add("");
                mainText.text = introLines[0];
                state = 2;
                Debug.Log("Entering state 2");
            }
        }
        else if(state == 2)
        {
            fadeText2();
        }
        else if(state == 3)
        {
            fadeOut(finalBlackoutImage, 0.0f);

            if (timer < 2.0f)
            { }
            else if (timer > 2.0f && timer <= 5.0f)
            {
                demonScript5.SetActive(true);
            }

            else if (timer < 8.0f)
            {
                demonScript5.SetActive(false);
                demonScript6.SetActive(true);
            }

            else if (timer < 11.0f)
            {
                demonScript6.SetActive(false);
                demonScript7.SetActive(true);
            }

            else if (timer < 14.0)
            {
                demonScript7.SetActive(false);
                demonScript8.SetActive(true);
            }

            else
            {
                demonScript8.SetActive(false);
                state = 4;
                timer = 0.0f;
            }
        }
        else if (state == 4)
        {
            fadeIn(finalBlackoutImage);

            if (timer < 2.0f)
            { }
            else if (timer < 5.0f)
            {
                demonScriptFinal.SetActive(true);
            }

            else if (timer < 6.0f)
            {
                demonScriptFinal.SetActive(false);
            }

            else
            {
                NextScene();
            }
        }
    }

    private void fadeText()
    {
        if (timer > 1.0f && timer < 2.0f)
            mainText.color = new Color(mainText.color.r, mainText.color.g, mainText.color.b, timer - 1.0f);
        else if (timer > 4.0f && timer <= 5.0f)
            mainText.color = new Color(mainText.color.r, mainText.color.g, mainText.color.b, 5.0f - timer);
        else if(timer > 5.0f)
        {
            mainText.color = new Color(mainText.color.r, mainText.color.g, mainText.color.b, 0.0f);
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

    private void fadeText2()
    {
        if (timer > 1.0f && timer < 2.0f)
            mainText.color = new Color(mainText.color.r, mainText.color.r, mainText.color.r, timer - 1.0f);
        else if (timer > 3.0f && timer <= 4.0f)
            mainText.color = new Color(mainText.color.r, mainText.color.r, mainText.color.r, 4.0f - timer);
        else if (timer > 4.0f)
        {
            mainText.color = new Color(mainText.color.r, mainText.color.r, mainText.color.r, 0.0f);
            timer = 0.0f;
            mainText.text = introLines[++lineCounter];

            if (lineCounter == introLines.Count - 1)
            {
                state = 3;
                finalBlackoutImage.color = new Color(0, 0, 0, 1.0f);
                bedroomBackground.SetActive(true);
                bedroomAnim.speed = 1.0f;
                bedroomDemon.SetActive(true);
                bedroomDemonAnim.speed = 1.0f;
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

    private bool fadeOut(Image img, float startTime)
    {
        img.color = new Color(img.color.r, img.color.r, img.color.r, startTime + 1.0f - timer);

        if (timer > startTime + 1.0)
        {
            img.color = new Color(img.color.r, img.color.r, img.color.r, 0.0f);
            return false;
        }

        return true;
    }

    private void NextScene()
    {
        SceneManager.LoadScene("House");
    }
}

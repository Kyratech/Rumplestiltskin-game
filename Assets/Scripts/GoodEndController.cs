using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoodEndController : MonoBehaviour
{
    [SerializeField]
    private GameObject husband;
    private Image husbandImg;
    [SerializeField]
    private GameObject protag;
    private Image protagImg;
    [SerializeField]
    private GameObject bg;

    [SerializeField]
    private Sprite protagTurn;
    [SerializeField]
    private Sprite protagSmile;
    [SerializeField]
    private Sprite husbandSmile;

    [SerializeField]
    private GameObject space;

    [SerializeField]
    private GameObject spaceBlackout;
    private Image spaceImg;

    [SerializeField]
    private GameObject blackout;
    private Image blackoutImg;

    private float timer;

    void Start()
    {
        husbandImg = husband.GetComponent<Image>();
        protagImg = protag.GetComponent<Image>();
        spaceImg = spaceBlackout.GetComponent<Image>();
        blackoutImg = blackout.GetComponent<Image>();

        timer = 0.0f;
    }

    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            NextScene();
        }

        timer += Time.deltaTime;

        if (timer < 1.0f)
        {
            fadeOut(blackoutImg, 0.0f);
        }
        else if (timer < 3.0f) { }
        else if (timer > 4.0f && timer < 5.0f)
        {
            fadeIn(spaceImg, 4.0f);
        }
        else if (timer < 7.0f) { }
        else if (timer < 8.0f)
        {
            space.SetActive(false);
            fadeOut(spaceImg, 7.0f);
            husband.SetActive(true);
            bg.SetActive(true);
        }
        else if (timer < 10.0f) { }
        else if (timer < 12.0f)
        {
            protagImg.sprite = protagTurn;
        }
        else if (timer < 14.0f)
        {
            protagImg.sprite = protagSmile;
        }
        else if (timer < 17.0f)
        {
            husbandImg.sprite = husbandSmile;
        }
        else if (timer < 20.0f) { }
        else if (timer < 22.0f)
        {
            fadeIn(blackoutImg, 20.0f);
        }
        else
        {
            NextScene();
        }
    }

    private bool fadeIn(Image img, float startTime)
    {
        img.color = new Color(img.color.r, img.color.r, img.color.r, timer - startTime);

        if (timer > startTime + 1.0)
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
        SceneManager.LoadScene("Title");
    }
}

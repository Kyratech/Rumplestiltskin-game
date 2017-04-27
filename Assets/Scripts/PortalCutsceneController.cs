using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalCutsceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject background;
    [SerializeField]
    private GameObject wide;
    [SerializeField]
    private GameObject close;

    [SerializeField]
    private GameObject blackout;
    private Image blackoutImage;

    public GameObject dialog1;
    public GameObject dialog2;

    private float timer;

    // Use this for initialization
    void Start()
    {
        blackoutImage = blackout.GetComponent<Image>();

        wide.SetActive(false);
        close.SetActive(false);
        dialog1.SetActive(false);
        dialog2.SetActive(false);

        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            NextScene();
        }

        timer += Time.deltaTime;

        if (timer < 1.0f)
        {
            fadeOut(blackoutImage, 0.0f);
        }
        else if (timer < 3.0f) { }
        else if (timer > 3.0f && timer < 4.0f)
        {
            fadeIn(blackoutImage, 3.0f);
        }
        else if (timer < 5.0f)
        {
            fadeOut(blackoutImage, 4.0f);
            wide.SetActive(true);
            dialog1.SetActive(true);
        }
        else if (timer < 8.0f) { }
        else if (timer > 8.0f && timer < 9.0f)
        {
            fadeIn(blackoutImage, 8.0f);
        }
        else if (timer < 10.0f)
        {
            fadeOut(blackoutImage, 9.0f);
            background.SetActive(false);
            wide.SetActive(false);
            dialog1.SetActive(false);
            close.SetActive(true);
            dialog2.SetActive(true);
        }
        else if (timer < 13.0f) { }
        else if (timer > 13.0f && timer < 14.0f)
        {
            fadeIn(blackoutImage, 13.0f);
        }
        else
        {
            SceneManager.LoadScene("Demon_Hub");
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
        SceneManager.LoadScene("Demon_Hub");
    }
}

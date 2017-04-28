using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinalDemonConversation : ConversationTile
{

    [SerializeField]
    private Sprite demonIdle;
    [SerializeField]
    private Sprite demonSmug;

    [SerializeField]
    private GameObject demon;

    [SerializeField]
    private GameObject readyOptions;

	public GameObject finalDemonBadEndDialogThree;
    public GameObject finalDemonGoodEndDialogTree;
    public GameObject finalDemonBestEndDialogTree;

    public override void initText()
    {
        
    }

    public override void dialogStart()
    {
        demon.GetComponent<SpriteRenderer>().sprite = demonSmug;
    }

    public override void dialogFinish()
    {
    	if(dialogBox == finalDemonBadEndDialogThree) {
    		SceneManager.LoadScene("Game_Over");
    	}
        else if(dialogBox == finalDemonBestEndDialogTree || dialogBox == finalDemonGoodEndDialogTree)
        {
            SceneManager.LoadScene("Good_End_Cutscene");
        }

        demon.GetComponent<SpriteRenderer>().sprite = demonIdle;
        dialogBox = readyOptions;
    }
}

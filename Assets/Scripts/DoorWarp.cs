using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorWarp : SceneWarp {

	public void ExitRoom() {
        controller.warpID = warpID;
		SceneManager.LoadScene(sceneToLoad);
	}

}